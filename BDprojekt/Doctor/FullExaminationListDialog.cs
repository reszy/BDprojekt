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
        private string resultText;
        private int resultId;
        private string resultCode;

        public string ResultText { get => resultText; set => resultText = value; }
        public int ResultId { get => resultId; set => resultId = value; }
        public string ResultCode { get => resultCode; set => resultCode = value; }

        List<Visit> visits;
        List<LaboratoryExamination> examsLab;
        List<PhysicalExamination> examsPhy;
        List<DictionaryMedicalExamination> examDictionary;

        public FullExaminationListDialog(int patientId)
        {
            InitializeComponent();

            visits = VisitsFacade.GetVisits(new Visit { PatientId = patientId }).ToList();

            foreach (var visit in visits)
            {
                examsLab = ExaminationFacade.GetLaboratoryExamination(new LaboratoryExamination { VisitId = patientId, Status = ExaminationStatus.PENDING.ToString() }).ToList();
                examsLab.AddRange(ExaminationFacade.GetLaboratoryExamination(new LaboratoryExamination { VisitId = patientId, Status = ExaminationStatus.READY.ToString() }).ToList());
                examsPhy = ExaminationFacade.GetPhysicalExamination(patientId).ToList();
                foreach (var exam in examsLab)
                {
                    this.examinationListDataGridView.Rows.Add(exam.DictionaryMedicalExamination.Name, exam.EndCancelDate, exam.Result, "Laboratoryjne");
                }
                foreach (var exam in examsPhy)
                {
                    this.examinationListDataGridView.Rows.Add(exam.DictionaryMedicalExamination.Name, "", exam.Result, "Fizykalne");
                }
            }
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (this.examinationListDataGridView.SelectedRows.Count == 1)
            {
                int choosedRow = this.examinationListDataGridView.CurrentCell.RowIndex;

                if (choosedRow >= examsLab.Count)
                {
                    var dialog = new PhysicalExaminationDialog(0, 0, 0, examsPhy[choosedRow - examsLab.Count]);
                    dialog.ShowDialog();
                }
                else
                {
                    var dialog = new LabManagerDialog(0, examsLab[choosedRow], true);
                    dialog.ShowDialog();
                }

            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
