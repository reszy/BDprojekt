namespace BDprojekt.Register
{
    partial class EditPatientDialog
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lastnameTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.peselTextBox = new System.Windows.Forms.TextBox();
            this.sexComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.birthdatePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.nipTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.adress = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.insuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.houseNoTextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.phoneNoTextBox = new System.Windows.Forms.TextBox();
            this.streetTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.placeNoTextBox = new System.Windows.Forms.TextBox();
            this.provinceTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.adress.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(218, 312);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Anuluj";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(137, 312);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 20;
            this.saveButton.Text = "Zapisz";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pesel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nazwisko:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Imie:";
            // 
            // lastnameTextBox
            // 
            this.lastnameTextBox.Location = new System.Drawing.Point(101, 54);
            this.lastnameTextBox.MaxLength = 40;
            this.lastnameTextBox.Name = "lastnameTextBox";
            this.lastnameTextBox.Size = new System.Drawing.Size(146, 20);
            this.lastnameTextBox.TabIndex = 16;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.Location = new System.Drawing.Point(101, 19);
            this.firstnameTextBox.MaxLength = 40;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(146, 20);
            this.firstnameTextBox.TabIndex = 15;
            // 
            // peselTextBox
            // 
            this.peselTextBox.Location = new System.Drawing.Point(101, 89);
            this.peselTextBox.MaxLength = 11;
            this.peselTextBox.Name = "peselTextBox";
            this.peselTextBox.Size = new System.Drawing.Size(146, 20);
            this.peselTextBox.TabIndex = 14;
            // 
            // sexComboBox
            // 
            this.sexComboBox.FormattingEnabled = true;
            this.sexComboBox.Items.AddRange(new object[] {
            "Kobieta",
            "Mężczyzna"});
            this.sexComboBox.Location = new System.Drawing.Point(101, 124);
            this.sexComboBox.Name = "sexComboBox";
            this.sexComboBox.Size = new System.Drawing.Size(146, 21);
            this.sexComboBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Płeć:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 163);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Data Urodzenia:";
            // 
            // birthdatePicker
            // 
            this.birthdatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.birthdatePicker.Location = new System.Drawing.Point(101, 160);
            this.birthdatePicker.Name = "birthdatePicker";
            this.birthdatePicker.Size = new System.Drawing.Size(146, 20);
            this.birthdatePicker.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Ubezpieczenie:";
            // 
            // nipTextBox
            // 
            this.nipTextBox.Location = new System.Drawing.Point(101, 195);
            this.nipTextBox.Name = "nipTextBox";
            this.nipTextBox.Size = new System.Drawing.Size(146, 20);
            this.nipTextBox.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(65, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "NIP:";
            // 
            // adress
            // 
            this.adress.Controls.Add(this.tabPage1);
            this.adress.Controls.Add(this.tabPage2);
            this.adress.Location = new System.Drawing.Point(12, 12);
            this.adress.Name = "adress";
            this.adress.SelectedIndex = 0;
            this.adress.Size = new System.Drawing.Size(285, 294);
            this.adress.TabIndex = 31;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.firstnameTextBox);
            this.tabPage1.Controls.Add(this.peselTextBox);
            this.tabPage1.Controls.Add(this.sexComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.birthdatePicker);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.lastnameTextBox);
            this.tabPage1.Controls.Add(this.nipTextBox);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.insuranceCheckBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(277, 268);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dane podstawowe";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // insuranceCheckBox
            // 
            this.insuranceCheckBox.AutoSize = true;
            this.insuranceCheckBox.Location = new System.Drawing.Point(101, 233);
            this.insuranceCheckBox.Name = "insuranceCheckBox";
            this.insuranceCheckBox.Size = new System.Drawing.Size(15, 14);
            this.insuranceCheckBox.TabIndex = 30;
            this.insuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.houseNoTextBox);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.phoneNoTextBox);
            this.tabPage2.Controls.Add(this.streetTextBox);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.placeNoTextBox);
            this.tabPage2.Controls.Add(this.provinceTextBox);
            this.tabPage2.Controls.Add(this.cityTextBox);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.zipCodeTextBox);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(277, 268);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Adres pocztowy";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(55, 241);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "Telefon:";
            // 
            // houseNoTextBox
            // 
            this.houseNoTextBox.Location = new System.Drawing.Point(110, 91);
            this.houseNoTextBox.MaxLength = 10;
            this.houseNoTextBox.Name = "houseNoTextBox";
            this.houseNoTextBox.Size = new System.Drawing.Size(146, 20);
            this.houseNoTextBox.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 94);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(72, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Numer Domu:";
            // 
            // phoneNoTextBox
            // 
            this.phoneNoTextBox.Location = new System.Drawing.Point(110, 238);
            this.phoneNoTextBox.MaxLength = 12;
            this.phoneNoTextBox.Name = "phoneNoTextBox";
            this.phoneNoTextBox.Size = new System.Drawing.Size(146, 20);
            this.phoneNoTextBox.TabIndex = 30;
            // 
            // streetTextBox
            // 
            this.streetTextBox.AcceptsReturn = true;
            this.streetTextBox.Location = new System.Drawing.Point(110, 54);
            this.streetTextBox.MaxLength = 50;
            this.streetTextBox.Name = "streetTextBox";
            this.streetTextBox.Size = new System.Drawing.Size(146, 20);
            this.streetTextBox.TabIndex = 2;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 205);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(77, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "Województwo:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(63, 21);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(41, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Miasto:";
            // 
            // placeNoTextBox
            // 
            this.placeNoTextBox.Location = new System.Drawing.Point(110, 129);
            this.placeNoTextBox.MaxLength = 10;
            this.placeNoTextBox.Name = "placeNoTextBox";
            this.placeNoTextBox.Size = new System.Drawing.Size(146, 20);
            this.placeNoTextBox.TabIndex = 4;
            // 
            // provinceTextBox
            // 
            this.provinceTextBox.Location = new System.Drawing.Point(110, 202);
            this.provinceTextBox.MaxLength = 50;
            this.provinceTextBox.Name = "provinceTextBox";
            this.provinceTextBox.Size = new System.Drawing.Size(146, 20);
            this.provinceTextBox.TabIndex = 28;
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(110, 18);
            this.cityTextBox.MaxLength = 50;
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(146, 20);
            this.cityTextBox.TabIndex = 1;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(4, 132);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(97, 13);
            this.label18.TabIndex = 17;
            this.label18.Text = "Numer Mieszkania:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(24, 169);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(77, 13);
            this.label19.TabIndex = 27;
            this.label19.Text = "Kod pocztowy:";
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.Location = new System.Drawing.Point(110, 166);
            this.zipCodeTextBox.MaxLength = 10;
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(146, 20);
            this.zipCodeTextBox.TabIndex = 26;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(67, 57);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(34, 13);
            this.label20.TabIndex = 23;
            this.label20.Text = "Ulica:";
            // 
            // EditPatientDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 343);
            this.Controls.Add(this.adress);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "EditPatientDialog";
            this.Text = "Edycja Pacienta";
            this.adress.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lastnameTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox peselTextBox;
        private System.Windows.Forms.ComboBox sexComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox insuranceCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker birthdatePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nipTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabControl adress;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox houseNoTextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox phoneNoTextBox;
        private System.Windows.Forms.TextBox streetTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox placeNoTextBox;
        private System.Windows.Forms.TextBox provinceTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.Label label20;
    }
}