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

namespace BDprojekt.Doctor
{
    public partial class LaboratoryExaminationDialog : Form
    {
        private int visitId;
        private int doctorId;
        private int patientId;

        private string choosenExamType;

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
            choosenExamType = dialog.ResultCode;
            this.textBox1.Text = dialog.ResultText;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ExaminationFacade.AddNewLaboratoryExamination(new LaboratoryExamination { DoctorAttention = this.richTextBox1.Text, OrderDate = DateTime.Now });
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
