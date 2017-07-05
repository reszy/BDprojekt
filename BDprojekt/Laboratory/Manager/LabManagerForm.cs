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
using BDprojekt.Laboratory.Manager;

namespace PresentationLayer
{
    public partial class LabManagerForm : Form
    {
        private LoginScreen mainForm;
        private List<LaboratoryExamination> examinations;
        private bool logout = false;

        public LabManagerForm(LoginScreen mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            RefreshList();
        }

        private void RefreshList()
        {
            examinations = ExaminationFacade.GetLaboratoryExamination(new LaboratoryExamination { Status = BusinessLayer.Enum.ExaminationStatus.TOCONFIRM.ToString() }).ToList();
            this.labExaminationDataGridView.Rows.Clear();
            foreach (var exam in examinations)
            {
                this.labExaminationDataGridView.Rows.Add(exam.OrderDate.ToString(), exam.Result, exam.DoctorAttention, exam.DictionaryMedicalExamination.Name, exam.MenagerAttention);
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

        private void DoExaminationButton_Click(object sender, EventArgs e)
        {
            if(this.labExaminationDataGridView.SelectedRows.Count == 1)
            {
                var exDialog = new LabManagerDialog(this.mainForm.LoggedId, examinations[this.labExaminationDataGridView.CurrentCell.RowIndex]);
                exDialog.ShowDialog();
                RefreshList();
            }
        }
    }
}
