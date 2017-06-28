using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataLayer;
using BusinessLayer;
using BDprojekt.Register;

namespace PresentationLayer.Clinic
{
    public partial class RegisterForm : Form
    {
        private LoginScreen mainForm;
        private bool logout = false;

        private List<Patient> patients;
        private List<Visit> visits;        

        public RegisterForm(LoginScreen mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();            

            this.refreshPatientList();
            this.refreshVisitList(-1);
        }

        private void refreshPatientList(bool getAll = true)
        {
            if (getAll)
                patients = PatientsFacade.GetPatients(new Patient()).ToList();
            


            this.patientsDataGrid.Rows.Clear();
            if (patients != null)
            {
                foreach (var patient in patients)
                {
                    string Street = "";
                    string City = "";
                    string HouseNr = "";
                    string PlaceNr = "";
                    string ZipCode = "";
                    string Province = "";
                    string Phone = "";

                    if (patient.Address != null)
                    {
                        Street = patient.Address.Street;
                        City = patient.Address.City;
                        HouseNr = patient.Address.HouseNr;
                        PlaceNr = patient.Address.PlaceNr;
                        ZipCode = patient.Address.ZipCode;
                        Province = patient.Address.Province;
                        Phone = patient.Address.Phone;
                    }

                    this.patientsDataGrid.Rows.Add(
                        patient.FirstName, patient.LastName, patient.Pesel, patient.Sex, patient.BirthdayDate.ToString(), patient.NIP, (patient.Insurance == 'Y'),
                        City, Street, HouseNr, PlaceNr, ZipCode, Province, Phone
                        );
                }
            }
            this.patientsDataGrid.ClearSelection();
            this.patientsDataGrid.Refresh();
        }

        private void refreshVisitList(int patientId)
        {
            if (patientId >= 0)
            {
                visits = VisitsFacade.GetVisits(new Visit { PatientId = patientId }).ToList();
            }
            else
            {
                visits = VisitsFacade.GetVisits(new Visit()).ToList();
            }


            this.visitDataGrid.Rows.Clear();
            if (visits != null)
            {
                foreach (var visit in visits)
                {
                    var doctor = PersonelFacade.GetUsers(new User { PersonId = visit.DoctorId }).ToList();

                    this.visitDataGrid.Rows.Add(
                        visit.Patient.FirstName + " " + visit.Patient.LastName, visit.DateOfRegistration.ToString(), doctor[0].LastName, visit.Status, visit.EndCancelDate.ToString() 
                        );
                }
            }
            this.visitDataGrid.ClearSelection();
            this.visitDataGrid.Refresh();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = false;
            this.Close();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if(logout)
                {
                    mainForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Patient patientCriteria = new Patient();

            patientCriteria.FirstName = this.firstNameTextBox.Text;
            patientCriteria.LastName = this.lastNameTextBox.Text;
            patientCriteria.Pesel = this.peselTextBox.Text;

            patients = PatientsFacade.GetPatients(patientCriteria).ToList();
            refreshPatientList(false);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.peselTextBox.Clear();

            this.refreshPatientList();
        }

        private void editPatientButton_Click(object sender, EventArgs e)
        {
            if (this.patientsDataGrid.SelectedRows.Count > 0)
            {
                var editDialog = new EditPatientDialog(patients[this.patientsDataGrid.CurrentCell.RowIndex]);
                editDialog.ShowDialog();
                refreshPatientList();
                refreshVisitList(0);
            }
        }

        private void addNewPatientButton_Click(object sender, EventArgs e)
        {
            var editDialog = new EditPatientDialog(null);
            editDialog.ShowDialog();
            refreshPatientList();
            refreshVisitList(0);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            refreshVisitList(-1);
            patientsDataGrid.ClearSelection();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (this.patientsDataGrid.SelectedRows.Count > 0)
            {
                var dialog = new RegisterDialog(patients[this.patientsDataGrid.CurrentCell.RowIndex].PatientId, mainForm.LoggedId);
                dialog.ShowDialog();

                refreshVisitList(patients[this.patientsDataGrid.CurrentCell.RowIndex].PatientId);
            }
        }

        private void deleteVisitButton_Click(object sender, EventArgs e)
        {
            if (this.visitDataGrid.SelectedRows.Count > 0)
            {
                Patient selected = visits[this.visitDataGrid.CurrentCell.RowIndex].Patient;
                Visit toDelete = visits[this.visitDataGrid.CurrentCell.RowIndex];
                if ( DialogResult.Yes == MessageBox.Show(
                    this,
                    "Czy napewno anulować wizytę pacjenta " + selected.FirstName + " " + selected.LastName + " w dniu " + toDelete.DateOfRegistration.ToShortDateString() + "?", "Usuwanie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ))
                {
                    VisitsFacade.CancelVisit(toDelete.VisitId);
                    refreshVisitList(this.patientsDataGrid.CurrentCell.RowIndex);
                }
            }
        }

        private void patientsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshVisitList(patients[this.patientsDataGrid.CurrentCell.RowIndex].PatientId);
        }
    }
}
