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

namespace BDprojekt.Doctor
{
    public partial class VisitDialog : Form
    {
        Visit visit;
        int doctorId;
        public VisitDialog(Visit visit, int doctorId, bool readOnly = false)
        {
            this.visit = visit;
            this.doctorId = doctorId;
            InitializeComponent();

            if(readOnly)
            {
                this.diagnosisTextBox.Text = visit.Diagnosis;
                this.DescriptionTextBox.Text = visit.Description;
                this.groupBox1.Enabled = false;
                this.saveButton.Enabled = false;
                this.saveButton.Visible = false;
                this.showExaminationsButton.Visible = true;
            }

            this.firstnameTextBox.Text = visit.Patient.FirstName;
            this.lastnameTextBox.Text = visit.Patient.LastName;
            this.registrationDateTextBox.Text = Convert.ToDateTime(visit.DateOfRegistration).ToString();
            this.statusTextBox.Text = visit.Status.ToString();
        }

        private void PhysicalExamButton_Click(object sender, EventArgs e)
        {
            var dialog = new PhysicalExaminationDialog(visit.VisitId, visit.PatientId, visit.DoctorId);
            dialog.ShowDialog();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ShowExaminationsButton_Click(object sender, EventArgs e)
        {
            var dialog = new ExaminationListDialog(ExaminationListDialog.Type.EXAMS, visit.PatientId);
            dialog.ShowDialog();
        }

        private void ShowVisitsButton_Click(object sender, EventArgs e)
        {
            var dialog = new ExaminationListDialog(ExaminationListDialog.Type.VISITS, visit.PatientId);
            dialog.ShowDialog();
        }

        private void laboratoryExamButton_Click(object sender, EventArgs e)
        {
            var dialog = new LaboratoryExaminationDialog(visit.VisitId, visit.PatientId, visit.DoctorId);
            dialog.ShowDialog();
        }
    }
}
