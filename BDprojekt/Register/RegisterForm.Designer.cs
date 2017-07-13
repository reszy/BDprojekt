namespace PresentationLayer.Clinic
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
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.visitDataGrid = new System.Windows.Forms.DataGridView();
            this.cancelVisitButton = new System.Windows.Forms.Button();
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
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insurance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.street = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.houseNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeNr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.zipCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.showAllButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.patientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfRegistration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endCancelDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.logoutToolStripMenuItem.Text = "Wyloguj";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.exitToolStripMenuItem.Text = "Zakończ";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
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
            this.visitDataGrid.AllowUserToAddRows = false;
            this.visitDataGrid.AllowUserToDeleteRows = false;
            this.visitDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.visitDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.visitDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientName,
            this.dateOfRegistration,
            this.doctorName,
            this.status,
            this.endCancelDate});
            this.visitDataGrid.Location = new System.Drawing.Point(5, 18);
            this.visitDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.visitDataGrid.Name = "visitDataGrid";
            this.visitDataGrid.ReadOnly = true;
            this.visitDataGrid.RowHeadersVisible = false;
            this.visitDataGrid.RowTemplate.Height = 24;
            this.visitDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.visitDataGrid.Size = new System.Drawing.Size(717, 179);
            this.visitDataGrid.TabIndex = 26;
            // 
            // cancelVisitButton
            // 
            this.cancelVisitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelVisitButton.Location = new System.Drawing.Point(129, 202);
            this.cancelVisitButton.Name = "cancelVisitButton";
            this.cancelVisitButton.Size = new System.Drawing.Size(117, 23);
            this.cancelVisitButton.TabIndex = 25;
            this.cancelVisitButton.Text = "Anuluj wizytę";
            this.cancelVisitButton.UseVisualStyleBackColor = true;
            this.cancelVisitButton.Click += new System.EventHandler(this.DeleteVisitButton_Click);
            // 
            // addNewPatientButton
            // 
            this.addNewPatientButton.Location = new System.Drawing.Point(6, 260);
            this.addNewPatientButton.Name = "addNewPatientButton";
            this.addNewPatientButton.Size = new System.Drawing.Size(117, 23);
            this.addNewPatientButton.TabIndex = 24;
            this.addNewPatientButton.Text = "Nowy pacjent";
            this.addNewPatientButton.UseVisualStyleBackColor = true;
            this.addNewPatientButton.Click += new System.EventHandler(this.AddNewPatientButton_Click);
            // 
            // editPatientButton
            // 
            this.editPatientButton.Location = new System.Drawing.Point(141, 260);
            this.editPatientButton.Name = "editPatientButton";
            this.editPatientButton.Size = new System.Drawing.Size(117, 23);
            this.editPatientButton.TabIndex = 23;
            this.editPatientButton.Text = "Edytuj dane pacjenta";
            this.editPatientButton.UseVisualStyleBackColor = true;
            this.editPatientButton.Click += new System.EventHandler(this.EditPatientButton_Click);
            // 
            // registerButton
            // 
            this.registerButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.registerButton.Location = new System.Drawing.Point(5, 202);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(117, 23);
            this.registerButton.TabIndex = 22;
            this.registerButton.Text = "Rejestruj";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.SystemColors.Control;
            this.searchButton.Location = new System.Drawing.Point(615, 11);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 20;
            this.searchButton.Text = "Szukaj";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(402, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pesel:";
            // 
            // peselTextBox
            // 
            this.peselTextBox.Location = new System.Drawing.Point(441, 26);
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(133, 20);
            this.peselTextBox.TabIndex = 18;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(254, 26);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(133, 20);
            this.firstNameTextBox.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Imie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwisko:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(77, 26);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(133, 20);
            this.lastNameTextBox.TabIndex = 14;
            // 
            // patientsDataGrid
            // 
            this.patientsDataGrid.AllowUserToAddRows = false;
            this.patientsDataGrid.AllowUserToDeleteRows = false;
            this.patientsDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patientsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientsDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstname,
            this.lastname,
            this.pesel,
            this.sex,
            this.birthdayDate,
            this.nip,
            this.insurance,
            this.city,
            this.street,
            this.houseNr,
            this.placeNr,
            this.zipCode,
            this.province,
            this.phone});
            this.patientsDataGrid.Location = new System.Drawing.Point(5, 18);
            this.patientsDataGrid.Margin = new System.Windows.Forms.Padding(2);
            this.patientsDataGrid.MultiSelect = false;
            this.patientsDataGrid.Name = "patientsDataGrid";
            this.patientsDataGrid.ReadOnly = true;
            this.patientsDataGrid.RowHeadersVisible = false;
            this.patientsDataGrid.RowTemplate.Height = 24;
            this.patientsDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsDataGrid.Size = new System.Drawing.Size(717, 237);
            this.patientsDataGrid.TabIndex = 28;
            this.patientsDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientsDataGrid_CellClick);
            // 
            // firstname
            // 
            this.firstname.HeaderText = "Imię";
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.HeaderText = "Nazwisko";
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // pesel
            // 
            this.pesel.HeaderText = "Pesel";
            this.pesel.Name = "pesel";
            this.pesel.ReadOnly = true;
            // 
            // sex
            // 
            this.sex.HeaderText = "Płeć";
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 80;
            // 
            // birthdayDate
            // 
            this.birthdayDate.HeaderText = "Data urodzenia";
            this.birthdayDate.Name = "birthdayDate";
            this.birthdayDate.ReadOnly = true;
            this.birthdayDate.Width = 125;
            // 
            // nip
            // 
            this.nip.HeaderText = "NIP";
            this.nip.Name = "nip";
            this.nip.ReadOnly = true;
            // 
            // insurance
            // 
            this.insurance.HeaderText = "Ubezpieczenie";
            this.insurance.Name = "insurance";
            this.insurance.ReadOnly = true;
            this.insurance.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.insurance.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // city
            // 
            this.city.HeaderText = "Miasto";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // street
            // 
            this.street.HeaderText = "Ulica";
            this.street.Name = "street";
            this.street.ReadOnly = true;
            // 
            // houseNr
            // 
            this.houseNr.HeaderText = "Nr. domu";
            this.houseNr.Name = "houseNr";
            this.houseNr.ReadOnly = true;
            // 
            // placeNr
            // 
            this.placeNr.HeaderText = "Nr. mieszkania";
            this.placeNr.Name = "placeNr";
            this.placeNr.ReadOnly = true;
            // 
            // zipCode
            // 
            this.zipCode.HeaderText = "Kod pocztowy";
            this.zipCode.Name = "zipCode";
            this.zipCode.ReadOnly = true;
            // 
            // province
            // 
            this.province.HeaderText = "Województwo";
            this.province.Name = "province";
            this.province.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "Telefon";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.patientsDataGrid);
            this.groupBox1.Controls.Add(this.addNewPatientButton);
            this.groupBox1.Controls.Add(this.editPatientButton);
            this.groupBox1.Location = new System.Drawing.Point(12, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 286);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pacienci";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.showAllButton);
            this.groupBox2.Controls.Add(this.visitDataGrid);
            this.groupBox2.Controls.Add(this.registerButton);
            this.groupBox2.Controls.Add(this.cancelVisitButton);
            this.groupBox2.Location = new System.Drawing.Point(12, 391);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(727, 228);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wizyty";
            // 
            // showAllButton
            // 
            this.showAllButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.showAllButton.Location = new System.Drawing.Point(252, 202);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(117, 23);
            this.showAllButton.TabIndex = 27;
            this.showAllButton.Text = "Pokaż wszytskie";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.ShowAllButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.clearButton);
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
            this.groupBox3.Size = new System.Drawing.Size(727, 69);
            this.groupBox3.TabIndex = 31;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Wyszukiwanie pacjentów";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(615, 40);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 21;
            this.clearButton.Text = "Wyczyść";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // patientName
            // 
            this.patientName.HeaderText = "Pacjent";
            this.patientName.Name = "patientName";
            this.patientName.ReadOnly = true;
            this.patientName.Width = 150;
            // 
            // dateOfRegistration
            // 
            this.dateOfRegistration.HeaderText = "Data rejestracji";
            this.dateOfRegistration.Name = "dateOfRegistration";
            this.dateOfRegistration.ReadOnly = true;
            this.dateOfRegistration.Width = 150;
            // 
            // doctorName
            // 
            this.doctorName.HeaderText = "Lekarz prowadzący";
            this.doctorName.Name = "doctorName";
            this.doctorName.ReadOnly = true;
            this.doctorName.Width = 150;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // endCancelDate
            // 
            this.endCancelDate.HeaderText = "Data zakończenia";
            this.endCancelDate.Name = "endCancelDate";
            this.endCancelDate.ReadOnly = true;
            this.endCancelDate.Width = 150;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegisterForm";
            this.Text = "Panel rejestratorki";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegisterForm_FormClosing);
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
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView visitDataGrid;
        private System.Windows.Forms.Button cancelVisitButton;
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
        private System.Windows.Forms.Button showAllButton;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn nip;
        private System.Windows.Forms.DataGridViewCheckBoxColumn insurance;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn street;
        private System.Windows.Forms.DataGridViewTextBoxColumn houseNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn placeNr;
        private System.Windows.Forms.DataGridViewTextBoxColumn zipCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfRegistration;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn endCancelDate;
    }
}