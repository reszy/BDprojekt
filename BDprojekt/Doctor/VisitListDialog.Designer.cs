namespace BDprojekt.Doctor
{
    partial class VisitListDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.selectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.examinationListDataGridView = new System.Windows.Forms.DataGridView();
            this.visitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitDiagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.visitStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examinationListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(468, 408);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 14;
            this.selectButton.Text = "Wybierz";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(549, 408);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.examinationListDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(612, 390);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // examinationListDataGridView
            // 
            this.examinationListDataGridView.AllowUserToAddRows = false;
            this.examinationListDataGridView.AllowUserToDeleteRows = false;
            this.examinationListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examinationListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitDate,
            this.visitDescription,
            this.visitDiagnosis,
            this.visitStatus});
            this.examinationListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.examinationListDataGridView.Location = new System.Drawing.Point(6, 19);
            this.examinationListDataGridView.Name = "examinationListDataGridView";
            this.examinationListDataGridView.Size = new System.Drawing.Size(600, 365);
            this.examinationListDataGridView.TabIndex = 0;
            // 
            // visitDate
            // 
            this.visitDate.HeaderText = "Data wykonania";
            this.visitDate.Name = "visitDate";
            this.visitDate.ReadOnly = true;
            // 
            // visitDescription
            // 
            this.visitDescription.HeaderText = "Opis";
            this.visitDescription.Name = "visitDescription";
            this.visitDescription.ReadOnly = true;
            // 
            // visitDiagnosis
            // 
            this.visitDiagnosis.HeaderText = "Diagnoza";
            this.visitDiagnosis.Name = "visitDiagnosis";
            this.visitDiagnosis.ReadOnly = true;
            // 
            // visitStatus
            // 
            this.visitStatus.HeaderText = "Status";
            this.visitStatus.Name = "visitStatus";
            this.visitStatus.ReadOnly = true;
            // 
            // VisitListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 440);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisitListDialog";
            this.Text = "HistoryListDialog";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examinationListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView examinationListDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDiagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitStatus;
    }
}