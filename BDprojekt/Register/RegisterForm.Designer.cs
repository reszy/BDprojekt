﻿namespace PresentationLayer.Clinic
{
    partial class RegisterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wylogujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyszukajPacientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajPacientaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wizytaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyszukajWizyteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.visitDataGrid = new System.Windows.Forms.DataGridView();
            this.deleteVisitButton = new System.Windows.Forms.Button();
            this.addNewPatientButton = new System.Windows.Forms.Button();
            this.editPatientButton = new System.Windows.Forms.Button();
            this.registerButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.patientsDataGrid = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGrid)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.pacientToolStripMenuItem,
            this.wizytaToolStripMenuItem,
            this.pomocToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(747, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wylogujToolStripMenuItem,
            this.zakończToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // wylogujToolStripMenuItem
            // 
            this.wylogujToolStripMenuItem.Name = "wylogujToolStripMenuItem";
            this.wylogujToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.wylogujToolStripMenuItem.Text = "Wyloguj";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.zakończToolStripMenuItem.Text = "Zakończ";
            // 
            // pacientToolStripMenuItem
            // 
            this.pacientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyszukajPacientaToolStripMenuItem,
            this.dodajPacientaToolStripMenuItem});
            this.pacientToolStripMenuItem.Name = "pacientToolStripMenuItem";
            this.pacientToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.pacientToolStripMenuItem.Text = "Pacient";
            // 
            // wyszukajPacientaToolStripMenuItem
            // 
            this.wyszukajPacientaToolStripMenuItem.Name = "wyszukajPacientaToolStripMenuItem";
            this.wyszukajPacientaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.wyszukajPacientaToolStripMenuItem.Text = "Wyszukaj pacienta";
            // 
            // dodajPacientaToolStripMenuItem
            // 
            this.dodajPacientaToolStripMenuItem.Name = "dodajPacientaToolStripMenuItem";
            this.dodajPacientaToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.dodajPacientaToolStripMenuItem.Text = "Dodaj Pacienta";
            // 
            // wizytaToolStripMenuItem
            // 
            this.wizytaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyszukajWizyteToolStripMenuItem});
            this.wizytaToolStripMenuItem.Name = "wizytaToolStripMenuItem";
            this.wizytaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.wizytaToolStripMenuItem.Text = "Wizyta";
            // 
            // wyszukajWizyteToolStripMenuItem
            // 
            this.wyszukajWizyteToolStripMenuItem.Name = "wyszukajWizyteToolStripMenuItem";
            this.wyszukajWizyteToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.wyszukajWizyteToolStripMenuItem.Text = "Wyszukaj wizyte";
            // 
            // pomocToolStripMenuItem
            // 
            this.pomocToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem});
            this.pomocToolStripMenuItem.Name = "pomocToolStripMenuItem";
            this.pomocToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.pomocToolStripMenuItem.Text = "Pomoc";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.oProgramieToolStripMenuItem.Text = "O programie...";
            // 
            // visitDataGrid
            // 
            this.visitDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitDataGrid.Location = new System.Drawing.Point(5, 18);
            this.visitDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.visitDataGrid.Name = "visitDataGrid";
            this.visitDataGrid.RowTemplate.Height = 24;
            this.visitDataGrid.Size = new System.Drawing.Size(717, 164);
            this.visitDataGrid.TabIndex = 26;
            // 
            // deleteVisitButton
            // 
            this.deleteVisitButton.Location = new System.Drawing.Point(141, 187);
            this.deleteVisitButton.Name = "deleteVisitButton";
            this.deleteVisitButton.Size = new System.Drawing.Size(117, 23);
            this.deleteVisitButton.TabIndex = 25;
            this.deleteVisitButton.Text = "Usuń wizytę";
            this.deleteVisitButton.UseVisualStyleBackColor = true;
            // 
            // addNewPatientButton
            // 
            this.addNewPatientButton.Location = new System.Drawing.Point(6, 260);
            this.addNewPatientButton.Name = "addNewPatientButton";
            this.addNewPatientButton.Size = new System.Drawing.Size(117, 23);
            this.addNewPatientButton.TabIndex = 24;
            this.addNewPatientButton.Text = "Nowy pacjent";
            this.addNewPatientButton.UseVisualStyleBackColor = true;
            // 
            // editPatientButton
            // 
            this.editPatientButton.Location = new System.Drawing.Point(141, 260);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(117, 23);
            this.editPatientButton.TabIndex = 23;
            this.editPatientButton.Text = "Edytuj dane pacjenta";
            this.editPatientButton.UseVisualStyleBackColor = true;
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(6, 187);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(117, 23);
            this.registerButton.TabIndex = 22;
            this.registerButton.Text = "Rejestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(647, 18);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(428, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pesel:";
            // 
            // peselTextBox
            // 
            this.peselTextBox.Location = new System.Drawing.Point(467, 21);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(150, 20);
            this.peselTextBox.TabIndex = 18;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(261, 21);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.firstNameTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Imie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwisko:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(64, 21);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.lastNameTextBox.TabIndex = 14;
            this.lastNameTextBox.Text = "K";
            // 
            // patientsDataGrid
            // 
            this.patientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGrid.Location = new System.Drawing.Point(5, 18);
            this.patientsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.patientsDataGrid.Name = "patientsDataGrid";
            this.patientsDataGrid.RowTemplate.Height = 24;
            this.patientsDataGrid.Size = new System.Drawing.Size(717, 237);
            this.patientsDataGrid.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.patientsDataGrid);
            this.groupBox1.Controls.Add(this.addNewPatientButton);
            this.groupBox1.Controls.Add(this.editPatientButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 291);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacienci";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.visitDataGrid);
            this.groupBox2.Controls.Add(this.registerButton);
            this.groupBox2.Controls.Add(this.deleteVisitButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 386);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 217);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wizyty";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Pokaż terminarz";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.lastNameTextBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.firstNameTextBox);
            this.groupBox3.Controls.Add(this.peselTextBox);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.groupBox3.Size = new System.Drawing.Size(727, 56);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyszukiwanie";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 612);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegisterForm";
            this.Text = "RegisterPanel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.visitDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGrid)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wylogujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyszukajPacientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajPacientaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem wizytaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyszukajWizyteToolStripMenuItem;
        private System.Windows.Forms.DataGridView visitDataGrid;
        private System.Windows.Forms.Button deleteVisitButton;
        private System.Windows.Forms.Button addNewPatientButton;
        private System.Windows.Forms.Button editPatientButton;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.DataGridView patientsDataGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}