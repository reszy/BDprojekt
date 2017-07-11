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
    public partial class ExaminationListDialog : Form
    {
        public enum Type { LAB_DICTIONARY, PH_DICTIONARY, EXAMS, VISITS };
        private enum ExamType { PH, LAB, NONE };
        ExamType examType = ExamType.NONE;
        Type dialogType;

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

        public ExaminationListDialog(Type e, int patientOrVisitId)
        {
            InitializeComponent();

            this.dialogType = e;

            switch (e)
            {
                case Type.LAB_DICTIONARY:
                    examType = ExamType.LAB;
                    examDictionary = ExaminationFacade.GetDictionaryMedicalExamination("LAB").ToList();
                    break;
                case Type.PH_DICTIONARY:
                    examType = ExamType.PH;
                    examDictionary = ExaminationFacade.GetDictionaryMedicalExamination("PHY").ToList();
                    break;
                case Type.EXAMS:
                    this.examinationListDataGridView.Columns[0].HeaderText = "Typ Badania";
                    this.examinationListDataGridView.Columns[1].HeaderText = "Data wykoniania";
                    this.examinationListDataGridView.Columns[2].HeaderText = "Wynik";
                    this.examinationListDataGridView.Columns[3].HeaderText = "Typ";
                    examsLab = ExaminationFacade.GetLaboratoryExamination(new LaboratoryExamination { VisitId = patientOrVisitId , Status = ExaminationStatus.PENDING.ToString()}).ToList();
                    examsLab.AddRange(ExaminationFacade.GetLaboratoryExamination(new LaboratoryExamination { VisitId = patientOrVisitId, Status = ExaminationStatus.READY.ToString() }).ToList());
                    examsPhy = ExaminationFacade.GetPhysicalExamination(patientOrVisitId).ToList();
                    foreach (var exam in examsLab)
                    {
                        this.examinationListDataGridView.Rows.Add(exam.DictionaryMedicalExamination.Name, exam.EndCancelDate, exam.Result, "Laboratoryjne");
                    }
                    foreach (var exam in examsPhy)
                    {
                        this.examinationListDataGridView.Rows.Add(exam.DictionaryMedicalExamination.Name, "", exam.Result, "Fizykalne");
                    }
                    break;
                case Type.VISITS:
                    this.examinationListDataGridView.Columns[0].HeaderText = "Data rejestracji";
                    this.examinationListDataGridView.Columns[1].HeaderText = "Data zakończenia";
                    this.examinationListDataGridView.Columns[2].HeaderText = "Opis";
                    this.examinationListDataGridView.Columns[3].HeaderText = "Diagnoza";
                    visits = VisitsFacade.GetVisits(new Visit { PatientId = patientOrVisitId }).ToList();
                    foreach(var visit in visits)
                    {
                        this.examinationListDataGridView.Rows.Add(visit.DateOfRegistration.ToString(), visit.EndCancelDate.ToString(), visit.Description, visit.Diagnosis);
                    }
                    break;
                default:
                    MessageBox.Show("Something happend. \nChoose wisely", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    this.Close();
                    break;
            }
            if(examType != ExamType.NONE)
            {
                this.examinationListDataGridView.Columns[0].HeaderText = "Nazwa";
                this.examinationListDataGridView.Columns[1].Visible = false;
                this.examinationListDataGridView.Columns[2].Visible = false;
                this.examinationListDataGridView.Columns[3].Visible = false;
                foreach (var item in examDictionary)
                {
                    this.examinationListDataGridView.Rows.Add(item.Name, "", "", "");
                }
            }
        }

        private void ChooseButton_Click(object sender, EventArgs e)
        {
            if (this.examinationListDataGridView.SelectedRows.Count == 1)
            {
                int choosedRow = this.examinationListDataGridView.CurrentCell.RowIndex;
                if (dialogType == Type.EXAMS)
                {
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
                if (dialogType == Type.VISITS)
                {
                    var dialog = new VisitDialog(visits[choosedRow], 0, true);
                    dialog.ShowDialog();
                }
                if (dialogType == Type.LAB_DICTIONARY || dialogType == Type.PH_DICTIONARY)
                {
                    var choosed = examDictionary[choosedRow];
                    ResultCode = choosed.MedicalExaminationCode;
                    ResultText = choosed.Name;
                    this.Close();
                }
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
