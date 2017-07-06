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
    public partial class LaboratoryExaminationDialog : Form
    {
        private int visitId;
        private int doctorId;
        private int patientId;

        private int choosenExamTypeId;

        public LaboratoryExaminationDialog(int visitId, int patientId, int doctorId)
        {
            this.visitId = visitId;
            this.patientId = patientId;
            this.doctorId = doctorId;
            InitializeComponent();
        }

        private void ChooseExamButton_Click(object sender, EventArgs e)
        {
            var dialog = new ExaminationListDialog(ExaminationListDialog.Type.LAB_EXAM, 0);
            dialog.ShowDialog();
        }
    }
}
