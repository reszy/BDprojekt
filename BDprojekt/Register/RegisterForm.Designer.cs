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
            this.btnShowVisists = new System.Windows.Forms.Button();
            this.dataGridViewVisits = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nazwisko = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imie = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pesel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lekarz = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(764, 24);
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
            // btnShowVisists
            // 
            this.btnShowVisists.Location = new System.Drawing.Point(597, 375);
            this.btnShowVisists.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowVisists.Name = "btnShowVisists";
            this.btnShowVisists.Size = new System.Drawing.Size(156, 47);
            this.btnShowVisists.TabIndex = 27;
            this.btnShowVisists.Text = "Pokaż Wizyty";
            this.btnShowVisists.UseVisualStyleBackColor = true;
            // 
            // dataGridViewVisits
            // 
            this.dataGridViewVisits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVisits.Location = new System.Drawing.Point(25, 375);
            this.dataGridViewVisits.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewVisits.Name = "dataGridViewVisits";
            this.dataGridViewVisits.RowTemplate.Height = 24;
            this.dataGridViewVisits.Size = new System.Drawing.Size(547, 226);
            this.dataGridViewVisits.TabIndex = 26;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(597, 120);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(155, 23);
            this.button5.TabIndex = 25;
            this.button5.Text = "Usuń wizytę";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(598, 209);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(155, 23);
            this.button4.TabIndex = 24;
            this.button4.Text = "Nowy pacjent";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(598, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(155, 20);
            this.button3.TabIndex = 23;
            this.button3.Text = "Edytuj dane pacjenta";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(597, 91);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(155, 23);
            this.button2.TabIndex = 22;
            this.button2.Text = "Rejestruj";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.Nazwisko,
            this.Imie,
            this.Pesel,
            this.Lekarz});
            this.dataGridView1.Location = new System.Drawing.Point(25, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(547, 254);
            this.dataGridView1.TabIndex = 21;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // Nazwisko
            // 
            this.Nazwisko.HeaderText = "Nazwisko";
            this.Nazwisko.Name = "Nazwisko";
            // 
            // Imie
            // 
            this.Imie.HeaderText = "Imie";
            this.Imie.Name = "Imie";
            // 
            // Pesel
            // 
            this.Pesel.HeaderText = "Pesel";
            this.Pesel.Name = "Pesel";
            // 
            // Lekarz
            // 
            this.Lekarz.HeaderText = "Lekarz";
            this.Lekarz.Name = "Lekarz";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(677, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Szukaj";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pesel";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(484, 35);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 18;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(278, 35);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Imie";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nazwisko";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.Text = "K";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 612);
            this.Controls.Add(this.btnShowVisists);
            this.Controls.Add(this.dataGridViewVisits);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "RegisterForm";
            this.Text = "RegisterPanel";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVisits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Button btnShowVisists;
        private System.Windows.Forms.DataGridView dataGridViewVisits;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nazwisko;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imie;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pesel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lekarz;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
    }
}