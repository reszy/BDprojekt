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
            this.ExaminationC1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExaminationC2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExaminationC3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.selectButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(615, 390);
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
            this.ExaminationC1,
            this.ExaminationC2,
            this.ExaminationC3,
            this.C4});
            this.examinationListDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.examinationListDataGridView.Location = new System.Drawing.Point(6, 19);
            this.examinationListDataGridView.Name = "examinationListDataGridView";
            this.examinationListDataGridView.ReadOnly = true;
            this.examinationListDataGridView.RowHeadersVisible = false;
            this.examinationListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.examinationListDataGridView.Size = new System.Drawing.Size(603, 365);
            this.examinationListDataGridView.TabIndex = 0;
            // 
            // ExaminationC1
            // 
            this.ExaminationC1.HeaderText = "Column1";
            this.ExaminationC1.Name = "ExaminationC1";
            this.ExaminationC1.ReadOnly = true;
            this.ExaminationC1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExaminationC2
            // 
            this.ExaminationC2.HeaderText = "Column2";
            this.ExaminationC2.Name = "ExaminationC2";
            this.ExaminationC2.ReadOnly = true;
            this.ExaminationC2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ExaminationC3
            // 
            this.ExaminationC3.HeaderText = "Column3";
            this.ExaminationC3.Name = "ExaminationC3";
            this.ExaminationC3.ReadOnly = true;
            this.ExaminationC3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // C4
            // 
            this.C4.HeaderText = "Column4";
            this.C4.Name = "C4";
            this.C4.ReadOnly = true;
            this.C4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // selectButton
            // 
            this.selectButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.selectButton.Location = new System.Drawing.Point(471, 407);
            this.selectButton.Name = "selectButton";
            this.selectButton.Size = new System.Drawing.Size(75, 23);
            this.selectButton.TabIndex = 11;
            this.selectButton.Text = "Wybierz";
            this.selectButton.UseVisualStyleBackColor = true;
            this.selectButton.Click += new System.EventHandler(this.ChooseButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.Location = new System.Drawing.Point(552, 408);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ExaminationListDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 442);
            this.Controls.Add(this.selectButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "ExaminationListDialog";
            this.Text = "Historia Badań";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.examinationListDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView examinationListDataGridView;
        private System.Windows.Forms.Button selectButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExaminationC1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExaminationC2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExaminationC3;
        private System.Windows.Forms.DataGridViewTextBoxColumn C4;
    }
}