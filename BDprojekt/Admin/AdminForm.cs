using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using DataLayer;

namespace PresentationLayer.Admin
{
    public partial class AdminForm : Form
    {
        Form mainForm;
        List<User> users;

        public AdminForm(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            users = AdministrationFacade.GetUsers(new DataLayer.User()).ToList();

            this.dataGridView.DataSource = users;
            this.dataGridView.Refresh();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var editDialog = new AdminDialog(null);
            editDialog.ShowDialog();

            users = AdministrationFacade.GetUsers(new DataLayer.User()).ToList();
            this.dataGridView.Refresh();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if(this.dataGridView.SelectedRows.Count > 0)
            {
                var editDialog = new AdminDialog(users[this.dataGridView.CurrentCell.RowIndex]);
                editDialog.ShowDialog();

                users = AdministrationFacade.GetUsers(new DataLayer.User()).ToList();
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(sender == this.logoutToolStripMenuItem)
            {
                mainForm.Show();
                this.Close();
            }
            else
            {
                Application.Exit();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AdminForm_FormClosing(this.logoutToolStripMenuItem, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.AdminForm_FormClosing(this.exitToolStripMenuItem, new FormClosingEventArgs(CloseReason.UserClosing, false));
        }
    }
}
