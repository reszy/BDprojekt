namespace BDprojekt.Doctor
{
    partial class FullExaminationListDialog
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
            this.showVisitButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.showExamButton = new System.Windows.Forms.Button();
            this.visitDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diagnosis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.examResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.examinationListDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.examinationListDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(838, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lista Badań";
            // 
            // examinationListDataGridView
            // 
            this.examinationListDataGridView.AllowUserToAddRows = false;
            this.examinationListDataGridView.AllowUserToDeleteRows = false;
            this.examinationListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.examinationListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examinationListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.visitDate,
            this.description,
            this.Diagnosis,
            this.examType,
            this.examCode,
            this.examName,
            this.examResult});
            this.examinationListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.examinationListDataGridView.Location = new System.Drawing.Point(6, 19);
            this.examinationListDataGridView.MultiSelect = false;
            this.examinationListDataGridView.Name = "examinationListDataGridView";
            this.examinationListDataGridView.ReadOnly = true;
            this.examinationListDataGridView.RowHeadersVisible = false;
            this.examinationListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examinationListDataGridView.Size = new System.Drawing.Size(826, 453);
            this.examinationListDataGridView.TabIndex = 0;
            // 
            // showVisitButton
            // 
            this.showVisitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showVisitButton.Location = new System.Drawing.Point(663, 526);
            this.showVisitButton.Name = "showVisitButton";
            this.showVisitButton.Size = new System.Drawing.Size(106, 23);
            this.showVisitButton.TabIndex = 11;
            this.showVisitButton.Text = "Podgląd wizyty";
            this.showVisitButton.UseVisualStyleBackColor = true;
            this.showVisitButton.Click += new System.EventHandler(this.ShowVisitButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Location = new System.Drawing.Point(775, 527);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 12;
            this.closeButton.Text = "Zamknij";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Enabled = false;
            this.firstnameTextBox.Location = new System.Drawing.Point(52, 17);
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(136, 20);
            this.firstnameTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Imię";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 20);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nazwisko";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Enabled = false;
            this.lastnameTextBox.Location = new System.Drawing.Point(291, 17);
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(136, 20);
            this.lastnameTextBox.TabIndex = 16;
            // 
            // showExamButton
            // 
            this.showExamButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.showExamButton.Location = new System.Drawing.Point(554, 526);
            this.showExamButton.Name = "showExamButton";
            this.showExamButton.Size = new System.Drawing.Size(103, 23);
            this.showExamButton.TabIndex = 18;
            this.showExamButton.Text = "Podgląd badania";
            this.showExamButton.UseVisualStyleBackColor = true;
            this.showExamButton.Click += new System.EventHandler(this.ShowExamButton_Click);
            // 
            // visitDate
            // 
            this.visitDate.HeaderText = "Data wizyty";
            this.visitDate.Name = "visitDate";
            this.visitDate.ReadOnly = true;
            this.visitDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.visitDate.Width = 150;
            // 
            // description
            // 
            this.description.HeaderText = "Opis";
            this.description.Name = "description";
            this.description.ReadOnly = true;
            this.description.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Diagnosis
            // 
            this.Diagnosis.HeaderText = "Diagnoza";
            this.Diagnosis.Name = "Diagnosis";
            this.Diagnosis.ReadOnly = true;
            this.Diagnosis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // examType
            // 
            this.examType.HeaderText = "Typ badania";
            this.examType.Name = "examType";
            this.examType.ReadOnly = true;
            this.examType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.examType.Width = 70;
            // 
            // examCode
            // 
            this.examCode.HeaderText = "Kod badania";
            this.examCode.Name = "examCode";
            this.examCode.ReadOnly = true;
            this.examCode.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.examCode.Width = 50;
            // 
            // examName
            // 
            this.examName.HeaderText = "Nazwa badania";
            this.examName.Name = "examName";
            this.examName.ReadOnly = true;
            this.examName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // examResult
            // 
            this.examResult.HeaderText = "Wynik badania";
            this.examResult.Name = "examResult";
            this.examResult.ReadOnly = true;
            this.examResult.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.examResult.Width = 200;
            // 
            // FullExaminationListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 561);
            this.Controls.Add(this.showExamButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lastnameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(this.showVisitButton);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "FullExaminationListDialog";
            this.Text = "Historia Badań";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examinationListDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showVisitButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.DataGridView examinationListDataGridView;
        private System.Windows.Forms.Button showExamButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn visitDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnosis;
        private System.Windows.Forms.DataGridViewTextBoxColumn examType;
        private System.Windows.Forms.DataGridViewTextBoxColumn examCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn examName;
        private System.Windows.Forms.DataGridViewTextBoxColumn examResult;
    }
}