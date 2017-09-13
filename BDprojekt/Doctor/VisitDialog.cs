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
using BusinessLayer.Enum;

namespace BDprojekt.Doctor
{
    public partial class VisitDialog : Form
    {
        Visit visit;
        int doctorId;
        bool readOnly;
        public VisitDialog(Visit visit, int doctorId, bool readOnly = false)
        {
            this.visit = visit;
            this.doctorId = doctorId;
            this.readOnly = readOnly;
            InitializeComponent();

            if (readOnly)
            {
                this.diagnosisTextBox.Text = visit.Diagnosis;
                this.DescriptionTextBox.Text = visit.Description;
                this.saveButton.Enabled = false;
                this.saveButton.Visible = false;
                this.diagnosisTextBox.Enabled = false;
                this.DescriptionTextBox.Enabled = false;
                this.physicalExamButton.Enabled = false;
                this.laboratoryExamButton.Enabled = false;
                this.showVisitsButton.Enabled = false;
                this.showExaminationsButton.Visible = true;
            }

            if (visit.Diagnosis != null)
                this.diagnosisTextBox.Text = visit.Diagnosis;
            if (visit.Description != null)
                this.DescriptionTextBox.Text = visit.Description;

            this.firstnameTextBox.Text = visit.Patient.FirstName;
            this.lastnameTextBox.Text = visit.Patient.LastName;
            this.registrationDateTextBox.Text = Convert.ToDateTime(visit.DateOfRegistration).ToString();
            this.statusTextBox.Text = visit.Status.ToString();
            QuickSave();
        }

        private void PhysicalExamButton_Click(object sender, EventArgs e)
        {
            QuickSave();
            var dialog = new PhysicalExaminationDialog(visit.VisitId, visit.PatientId, visit.DoctorId);
            dialog.ShowDialog();
        }

        private void EndVisitButton_Click(object sender, EventArgs e)
        {
            if (!readOnly)
            {
                visit.EndCancelDate = DateTime.Now;
                visit.Status = VisitStatus.FINISH.ToString();
                visit.DoctorId = doctorId;
                visit.Description = this.DescriptionTextBox.Text;
                visit.Diagnosis = this.diagnosisTextBox.Text;
                VisitsFacade.UpdateVisit(visit);
            }
            this.Close();
        }

        private void ShowExaminationsButton_Click(object sender, EventArgs e)
        {
            QuickSave();
            var dialog = new ExaminationListDialog(ExaminationListDialog.Type.EXAMS, visit.VisitId);
            dialog.ShowDialog();
        }

        private void ShowVisitsButton_Click(object sender, EventArgs e)
        {
            QuickSave();
            var dialog = new ExaminationListDialog(ExaminationListDialog.Type.VISITS, visit.PatientId);
            dialog.ShowDialog();
        }

        private void LaboratoryExamButton_Click(object sender, EventArgs e)
        {
            QuickSave();
            var dialog = new LaboratoryExaminationDialog(visit.VisitId, visit.PatientId, visit.DoctorId);
            dialog.ShowDialog();
        }

        private void QuickSave()
        {
            if(doctorId == visit.DoctorId && !readOnly)
            {
                if(visit.Status == VisitStatus.REGISTER.ToString())
                    visit.Status = VisitStatus.INPROGRESS.ToString();
                
                visit.DoctorId = doctorId;
                visit.Description = this.DescriptionTextBox.Text;
                visit.Diagnosis = this.diagnosisTextBox.Text;
                VisitsFacade.UpdateVisit(visit);
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            QuickSave();
            this.Close();
        }
    }
}
