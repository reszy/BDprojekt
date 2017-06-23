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

        private bool logout;

        public AdminForm(Form mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            var roles = UserRole.Values.ToList();
            roles.Insert(0,UserRole.EMPTY);
            this.roleComboBox.DataSource = roles;

            refreshList();
        }

        private void refreshList(bool getAll = true)
        {
            this.dataGridView.Rows.Clear();
            if (getAll)
            {
                users = AdministrationFacade.GetUsers(new DataLayer.User()).ToList();
            }
            if(users!=null)
            {
                foreach (var u in users)
                {
                    string Street = "";
                    string City = "";
                    string HouseNr = "";
                    string PlaceNr = "";
                    string ZipCode = "";
                    string Province = "";
                    string Phone = "";

                    if (u.Address != null)
                    {
                        Street = u.Address.Street;
                        City = u.Address.City;
                        HouseNr = u.Address.HouseNr;
                        PlaceNr = u.Address.PlaceNr;
                        ZipCode = u.Address.ZipCode;
                        Province = u.Address.Province;
                        Phone = u.Address.Phone;
                    }

                    this.dataGridView.Rows.Add(
                        u.Uname, u.FirstName, u.LastName, u.Role, u.DateRetire.ToString(),
                        City, Street, HouseNr, PlaceNr, ZipCode, Province, Phone
                        );
                }
            }
            this.dataGridView.Refresh();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            var editDialog = new AdminDialog(null);
            editDialog.ShowDialog();
            refreshList();
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if(this.dataGridView.SelectedRows.Count > 0)
            {
                var editDialog = new AdminDialog(users[this.dataGridView.CurrentCell.RowIndex]);
                editDialog.ShowDialog();
                refreshList();
            }
        }

        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (logout)
                {
                    mainForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = false;
            this.Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            User searchCriteria = new User();
            searchCriteria.FirstName = this.firstNameTextBox.Text;
            searchCriteria.LastName = this.lastnameTextBox.Text;
            searchCriteria.Uname = this.loginTextBox.Text;
            searchCriteria.Role = this.roleComboBox.Text;

            users = AdministrationFacade.GetUsers(searchCriteria).ToList();
            this.refreshList(false);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            this.lastnameTextBox.Clear();
            this.firstNameTextBox.Clear();
            this.roleComboBox.SelectedIndex = 0;
            this.loginTextBox.Clear();

            refreshList();
        }
    }
}
