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

        private string choosenExamType;

        public PhysicalExaminationDialog(int visitId, int patientId, int doctorId)
        {
            InitializeComponent();
        }

        private void ChooseExamButton_Click(object sender, EventArgs e)
        {
            var dialog = new ExaminationListDialog(ExaminationListDialog.Type.PH_DICTIONARY, 0);
            dialog.ShowDialog();
            choosenExamType = dialog.ResultCode;
            this.textBox1.Text = dialog.ResultText;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
