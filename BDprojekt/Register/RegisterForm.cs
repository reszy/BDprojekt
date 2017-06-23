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
        private Form mainForm;
        private bool logout = false;

        private List<Patient> patients;
        private List<Visit> visits;
        RegistrationFacade rFacade;

        public RegisterForm(Form mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();
            this.rFacade = new RegistrationFacade();

            this.refreshPatientList();
        }

        private void refreshPatientList()
        {
            patients = rFacade.GetPatients(new DataLayer.Patient()).ToList();

            this.patientsDataGrid.DataSource = null;
            this.patientsDataGrid.DataSource = patients;
            this.patientsDataGrid.Refresh();
        }

        private void refreshVisitList(int patientId)
        {
            if (patientId > 0)
            {
                visits = rFacade.GetVisits(patientId).ToList();
            }
            else
            {
                visits = null;
            }
            this.visitDataGrid.DataSource = null;
            this.visitDataGrid.DataSource = visits;
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

            rFacade.GetPatients(patientCriteria);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.firstNameTextBox.Clear();
            this.lastNameTextBox.Clear();
            this.peselTextBox.Clear();
        }

        private void editPatientButton_Click(object sender, EventArgs e)
        {
            if (this.patientsDataGrid.SelectedRows.Count > 0)
            {
                var editDialog = new EditpatientDialog(patients[this.patientsDataGrid.CurrentCell.RowIndex]);
                editDialog.ShowDialog();
                refreshPatientList();
                refreshVisitList(0);
            }
        }

        private void addNewPatientButton_Click(object sender, EventArgs e)
        {
            var editDialog = new EditpatientDialog(null);
            editDialog.ShowDialog();
            refreshPatientList();
            refreshVisitList(0);
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            refreshVisitList(0);//TODO make to pass null or something to get all visits today
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            //TODO 

            var dialog = new RegisterDialog();
            dialog.ShowDialog();

            refreshVisitList(patients[this.patientsDataGrid.CurrentCell.RowIndex].PatientId);
        }

        private void deleteVisitButton_Click(object sender, EventArgs e)
        {
            if (this.visitDataGrid.SelectedRows.Count > 0)
            {
                Patient selected = patients[this.patientsDataGrid.CurrentCell.RowIndex];
                Visit toDelete = visits[this.visitDataGrid.CurrentCell.RowIndex];
                if ( DialogResult.Yes == MessageBox.Show(
                    this,
                    "Czy napewno usunąć wizytę pacjenta " + selected.FirstName + " " + selected.LastName + " w dniu " + toDelete.DateOfRegistration.ToShortDateString() + "?", "Usuwanie",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ))
                {
                    //rFacade.updateVisit(selected.PatientId); TODO add deleteing visit in DB
                    refreshVisitList(selected.PatientId);
                }
            }
        }

        private void patientsDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refreshVisitList(patients[this.patientsDataGrid.CurrentCell.RowIndex].PatientId);
        }
    }
}
