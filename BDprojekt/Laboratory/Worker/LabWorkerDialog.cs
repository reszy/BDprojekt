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

namespace BDprojekt.Laboratory.Manager
{
    public partial class LabWorkerDialog : Form
    {
        private int labWorkerId;
        private LaboratoryExamination examination;

        public LabWorkerDialog(int labWorkerId, LaboratoryExamination examination)
        {
            this.labWorkerId = labWorkerId;
            this.examination = examination;
            InitializeComponent();

            this.doctorCommentsRichTextBox.Text = examination.DoctorAttention;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.examination.Result = this.resultsRichTextBox.Text;
            this.examination.Status = BusinessLayer.Enum.ExaminationStatus.TOCONFIRM.ToString();
            this.examination.LabWorkerId = labWorkerId;

            LaboratoryFacade.UpdateLaboratoryExamination(examination);

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
