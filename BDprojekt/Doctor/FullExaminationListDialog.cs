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
using BDprojekt.Laboratory.Manager;

namespace BDprojekt.Doctor
{
    public partial class FullExaminationListDialog : Form
    {

        List<Row> examsList;

        private struct Row
        {
            public Visit visit;
            public LaboratoryExamination labExamination;
            public PhysicalExamination phyExamination;
        }

        public FullExaminationListDialog(int patientId)
        {
            InitializeComponent();

            List<Visit> visits = VisitsFacade.GetVisits(new Visit { PatientId = patientId }).ToList();

            if(visits.Count > 0)
            {
                firstnameTextBox.Text = visits[0].Patient.FirstName;
                lastnameTextBox.Text = visits[0].Patient.LastName;
            }

            examsList = new List<Row>();

            foreach (var visit in visits)
            {
                List<LaboratoryExamination> examsLab = ExaminationFacade.GetLaboratoryExamination(new LaboratoryExamination { VisitId = visit.VisitId }).ToList();
                List<PhysicalExamination> examsPhy = ExaminationFacade.GetPhysicalExamination(visit.VisitId).ToList();
                foreach (var exam in examsLab)
                {
                    examsList.Add(new Row { visit = visit, labExamination = exam, phyExamination = null });
                }
                foreach (var exam in examsPhy)
                {
                    examsList.Add(new Row { visit = visit, labExamination = null, phyExamination = exam });
                }
            }

            foreach (var row in examsList)
            {
                string examType = "";
                string examCode = "";
                string examName = "";
                string examResult = "";

                if (row.labExamination != null)
                {
                    examType = "Lab";
                    examCode = row.labExamination.DictionaryMedicalExamination.MedicalExaminationCode;
                    examName = row.labExamination.DictionaryMedicalExamination.Name;
                    examResult = row.labExamination.Result;
                }
                else
                {
                    if (row.phyExamination != null)
                    {
                        examType = "Fiz";
                        examCode = row.phyExamination.DictionaryMedicalExamination.MedicalExaminationCode;
                        examName = row.phyExamination.DictionaryMedicalExamination.Name;
                        examResult = row.phyExamination.Result;
                    }
                }
                this.examinationListDataGridView.Rows.Add(row.visit.EndCancelDate, row.visit.Description, row.visit.Diagnosis, examType, examCode, examName, examResult);
            }
        }

        private void ShowExamButton_Click(object sender, EventArgs e)
        {
            if (this.examinationListDataGridView.SelectedRows.Count == 1)
            {
                int choosedRow = this.examinationListDataGridView.CurrentCell.RowIndex;

                if (examsList[choosedRow].labExamination != null)
                {
                    var dialog = new LabManagerDialog(0, examsList[choosedRow].labExamination, true);
                    dialog.ShowDialog();
                }
                else
                {
                    if (examsList[choosedRow].phyExamination != null)
                    {
                        var dialog = new PhysicalExaminationDialog(0, 0, 0, examsList[choosedRow].phyExamination);
                        dialog.ShowDialog();
                    }
                }
            }
        }
        private void ShowVisitButton_Click(object sender, EventArgs e)
        {
            if (this.examinationListDataGridView.SelectedRows.Count == 1)
            {
                int choosedRow = this.examinationListDataGridView.CurrentCell.RowIndex;

                var dialog = new VisitDialog(examsList[choosedRow].visit, 0, true);
                dialog.ShowDialog();

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
