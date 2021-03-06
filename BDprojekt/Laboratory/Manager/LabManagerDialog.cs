﻿using BusinessLayer;
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

namespace BDprojekt.Laboratory.Manager
{
    public partial class LabManagerDialog : Form
    {
        private int labManagerId;
        private LaboratoryExamination examination;

        public LabManagerDialog(int labManagerId, LaboratoryExamination examination, bool viewOnly = false)
        {
            this.labManagerId = labManagerId;
            this.examination = examination;
            InitializeComponent();

            this.doctorCommentRichTextBox.Text = examination.DoctorAttention;
            this.resultRichTextBox.Text = examination.Result;
            this.nameRichTextBox.Text = examination.DictionaryMedicalExamination.Name;
            if (viewOnly)
            {
                this.managerCommentRichTextBox.Enabled = false;
                this.cancelButton.Visible = false;
                this.saveButton.Visible = false;
                this.cancelButton.Enabled = false;
                this.saveButton.Enabled = false;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            this.examination.Status = BusinessLayer.Enum.ExaminationStatus.READY.ToString();
            this.examination.LaboratoryManagerId = this.labManagerId;
            this.examination.ApprovalCancelDate = DateTime.Now;
            this.examination.MenagerAttention = this.managerCommentRichTextBox.Text;

            ExaminationFacade.UpdateLaboratoryExamination(examination);

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.examination.Status = BusinessLayer.Enum.ExaminationStatus.CANCEL_MAN.ToString();
            this.examination.LaboratoryManagerId = this.labManagerId;
            this.examination.ApprovalCancelDate = DateTime.Now;
            this.examination.MenagerAttention = this.managerCommentRichTextBox.Text;

            ExaminationFacade.UpdateLaboratoryExamination(examination);

            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
