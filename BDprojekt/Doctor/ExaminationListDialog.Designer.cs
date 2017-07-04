namespace BDprojekt.Doctor
{
    partial class ExaminationListDialog
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.examinationListDataGridView = new System.Windows.Forms.DataGridView();
            this.ExaminationType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExaminationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExaminationResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examinationListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.examinationListDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 390);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista";
            // 
            // examinationListDataGridView
            // 
            this.examinationListDataGridView.AllowUserToAddRows = false;
            this.examinationListDataGridView.AllowUserToDeleteRows = false;
            this.examinationListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examinationListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ExaminationType,
            this.ExaminationDate,
            this.ExaminationResult});
            this.examinationListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.examinationListDataGridView.Location = new System.Drawing.Point(6, 19);
            this.examinationListDataGridView.Name = "examinationListDataGridView";
            this.examinationListDataGridView.Size = new System.Drawing.Size(391, 365);
            this.examinationListDataGridView.TabIndex = 0;
            // 
            // ExaminationType
            // 
            this.ExaminationType.HeaderText = "Typ badania";
            this.ExaminationType.Name = "ExaminationType";
            this.ExaminationType.ReadOnly = true;
            // 
            // ExaminationDate
            // 
            this.ExaminationDate.HeaderText = "Data wykonania";
            this.ExaminationDate.Name = "ExaminationDate";
            this.ExaminationDate.ReadOnly = true;
            // 
            // ExaminationResult
            // 
            this.ExaminationResult.HeaderText = "Wynik badania";
            this.ExaminationResult.Name = "ExaminationResult";
            this.ExaminationResult.ReadOnly = true;
            // 
            // selectButton
            // 
            this.selectButton.Location = new System.Drawing.Point(259, 407);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 11;
            this.selectButton.Text = "Wybierz";
            this.selectButton.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(340, 407);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // ExaminationListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 442);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ExaminationListDialog";
            this.Text = "ListDialog";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examinationListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView examinationListDataGridView;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExaminationType;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExaminationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExaminationResult;
    }
}