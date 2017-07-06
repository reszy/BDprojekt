using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDprojekt.Doctor
{
    public partial class ExaminationListDialog : Form
    {
        public ExaminationListDialog()
        {
            InitializeComponent();
        }
        public enum Type { LAB_EXAM, PH_EXAM, EXAMS, VISITS };
        private enum ExamType { PH, LAB };
        ExamType examType;


        private string resultText;
        private int resultId;

        public string ResultText { get => resultText; set => resultText = value; }
        public int ResultId { get => resultId; set => resultId = value; }

        public ExaminationListDialog(Type e, int patientId)
        {
            InitializeComponent();

            switch (e)
            {
                case Type.LAB_EXAM:
                    examType = ExamType.LAB;
                    goto case Type.PH_EXAM;
                case Type.PH_EXAM:
                    examType = ExamType.PH;
                    this.examinationListDataGridView.Columns[0].HeaderText = "Nazwa";
                    this.examinationListDataGridView.Columns[1].Visible = false;
                    this.examinationListDataGridView.Columns[2].Visible = false;
                    this.examinationListDataGridView.Columns[3].Visible = false;
                    break;
                case Type.EXAMS:
                    this.examinationListDataGridView.Columns[0].HeaderText = "Typ Badania";
                    this.examinationListDataGridView.Columns[1].HeaderText = "Data wykoniania";
                    this.examinationListDataGridView.Columns[2].HeaderText = "Wynik";
                    this.examinationListDataGridView.Columns[3].HeaderText = "Uwagi kierownika";
                    break;
                case Type.VISITS:
                    this.examinationListDataGridView.Columns[0].HeaderText = "Data rejestracji";
                    this.examinationListDataGridView.Columns[1].HeaderText = "Data zakończenia";
                    this.examinationListDataGridView.Columns[2].HeaderText = "Opis";
                    this.examinationListDataGridView.Columns[3].HeaderText = "Diagnoza";
                    break;
                default:
                    MessageBox.Show("Something happend. \nChoose wisely", "Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                    break;
            }
        }

        private void ExaminationListDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
