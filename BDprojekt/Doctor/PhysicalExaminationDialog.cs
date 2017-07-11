using BusinessLayer;
using DataLayer;
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
    public partial class PhysicalExaminationDialog : Form
    {
        private int visitId;
        private int doctorId;
        private int patientId;

        private string choosenExamCode;

        public PhysicalExaminationDialog(int visitId, int patientId, int doctorId, PhysicalExamination exam = null)
        {
            this.visitId = visitId;
            this.patientId = patientId;
            this.doctorId = doctorId;
            InitializeComponent();

            if(exam != null)
            {
                this.examinationTextBox.Text = exam.MedicalExaminationCode.ToString() + ' ' + exam.DictionaryMedicalExamination.Name;
                this.resultTextBox.Text = exam.Result;
                this.chooseExamButton.Visible = false;
                this.groupBox2.Text = "Badanie";
            }
        }

        private void ChooseExamButton_Click(object sender, EventArgs e)
        {
            var dialog = new ExaminationListDialog(ExaminationListDialog.Type.PH_DICTIONARY, 0);
            dialog.ShowDialog();
            choosenExamCode = dialog.ResultCode;
            this.examinationTextBox.Text = dialog.ResultText;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ExaminationFacade.AddNewPhysicalExamination(new PhysicalExamination { Result = this.resultTextBox.Text, VisitId = visitId, MedicalExaminationCode = choosenExamCode });
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
