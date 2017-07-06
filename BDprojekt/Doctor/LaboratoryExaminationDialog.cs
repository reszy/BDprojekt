using System;
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
using BusinessLayer.Enum;

namespace BDprojekt.Doctor
{
    public partial class LaboratoryExaminationDialog : Form
    {
        private int visitId;
        private int doctorId;
        private int patientId;

        private string choosenExamCode;

        public LaboratoryExaminationDialog(int visitId, int patientId, int doctorId)
        {
            this.visitId = visitId;
            this.patientId = patientId;
            this.doctorId = doctorId;
            InitializeComponent();
        }

        private void ChooseExamButton_Click(object sender, EventArgs e)
        {
            var dialog = new ExaminationListDialog(ExaminationListDialog.Type.LAB_DICTIONARY, 0);
            dialog.ShowDialog();
            choosenExamCode = dialog.ResultCode;
            this.textBox1.Text = dialog.ResultText;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ExaminationFacade.AddNewLaboratoryExamination(new LaboratoryExamination { DoctorAttention = this.richTextBox1.Text, OrderDate = DateTime.Now, Status = ExaminationStatus.PENDING.ToString(), VisitId = visitId, MedicalExaminationCode = choosenExamCode});
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
