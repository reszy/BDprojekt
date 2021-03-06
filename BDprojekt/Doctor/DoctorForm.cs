﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using DataLayer;
using BDprojekt.Doctor;
using BusinessLayer.Enum;

namespace PresentationLayer
{
    public partial class DoctorPanel : Form
    {

        private LoginScreen mainForm;
        private bool logout = false;

        private List<Visit> visits;

        public DoctorPanel(LoginScreen mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();

            var visitStatuses = VisitStatus.Values.ToList();
            this.visitStatusComboBox.DataSource = visitStatuses;

            this.RefreshVisitList();
        }

        private void RefreshVisitList()
        {
            Patient patientCriteria = new Patient()
            {
                FirstName = this.firstNameTextBox.Text,
                LastName = this.lastnameTextBox.Text,
                Pesel = this.peselTextBox.Text
            };
            List<Patient> patient = null;
            if (!(String.IsNullOrEmpty(patientCriteria.FirstName) && String.IsNullOrEmpty(patientCriteria.LastName) && String.IsNullOrEmpty(patientCriteria.Pesel)))
            {
                patient = PatientsFacade.GetPatients(patientCriteria).ToList();
            }

            Visit visitCriteria = new Visit()
            {
                Status = this.visitStatusComboBox.Text
            };

            if(myVisitsCheckBox.Checked)
            {
                visitCriteria.DoctorId = mainForm.LoggedId;
            }

            if (patient != null && patient.Count > 0)
            {
                visitCriteria.PatientId = patient[0].PatientId;
            }
            if (this.dateTimePicker.Checked)
            {
                visitCriteria.DateOfRegistration = dateTimePicker.Value;
            }

            visits = VisitsFacade.GetVisits(visitCriteria).ToList();


            this.visitDataGrid.Rows.Clear();
            if (visits != null)
            {
                foreach (var visit in visits)
                {
                    var doctor = PersonelFacade.GetUsers(new User { PersonId = mainForm.LoggedId }).ToList();

                    this.visitDataGrid.Rows.Add(
                        visit.Patient.FirstName + " " + visit.Patient.LastName, 
                        visit.Patient.Pesel, 
                        visit.DateOfRegistration.ToString(),
                        visit.Status
                        );
                }
            }
            this.visitDataGrid.ClearSelection();
            this.visitDataGrid.Refresh();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = false;
            this.Close();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (logout)
                {
                    mainForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            RefreshVisitList();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.firstNameTextBox.Clear();
            this.lastnameTextBox.Clear();
            this.peselTextBox.Clear();
            this.dateTimePicker.Checked = false;
            this.myVisitsCheckBox.Checked = true;
            this.visitStatusComboBox.SelectedIndex = 0;

            this.RefreshVisitList();
        }

        private void OpenVisitButton_Click(object sender, EventArgs e)
        {
            if (this.visitDataGrid.SelectedRows.Count == 1)
            {
                var choosedVisit = visits[this.visitDataGrid.CurrentCell.RowIndex];

                bool isReadOnly = choosedVisit.DoctorId != mainForm.LoggedId || choosedVisit.Status == VisitStatus.CANCEL.ToString();

                var dialog = new VisitDialog(choosedVisit, mainForm.LoggedId, isReadOnly);
                dialog.ShowDialog();

                RefreshVisitList();
            }
        }

        private void ExaminationHistoryButton_Click(object sender, EventArgs e)
        {
            if (this.visitDataGrid.SelectedRows.Count == 1)
            {
                var choosedVisit = visits[this.visitDataGrid.CurrentCell.RowIndex];
                var dialog = new FullExaminationListDialog(choosedVisit.PatientId);
                dialog.ShowDialog();
            }
        }
    }
}
