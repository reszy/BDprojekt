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

namespace PresentationLayer
{
    public partial class LabWorkerForm : Form
    {
        private LoginScreen mainForm;
        List<LaboratoryExamination> examinations;
        private bool logout;

        public LabWorkerForm(LoginScreen mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            RefreshList();
        }

        private void RefreshList()
        {
            examinations = LaboratoryFacade.GetLaboratoryExamination(BusinessLayer.Enum.ExaminationStatus.PENDING).ToList();
            this.labExaminationDataGridView.Rows.Clear();
            foreach (var exam in examinations)
            {
                this.labExaminationDataGridView.Rows.Add(exam.OrderDate.ToString(), exam.DoctorAttention, exam.DictionaryMedicalExamination.Name);
            }
            this.labExaminationDataGridView.ClearSelection();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = false;
            this.Close();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (logout)
                {
                    mainForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
