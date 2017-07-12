using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer.Enum;
using BusinessLayer;
using DataLayer;
using BDprojekt;

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

            RefreshList();
        }

        private void RefreshList(bool getAll = true)
        {
            this.dataGridView.Rows.Clear();
            if (getAll)
            {
                users = PersonelFacade.GetUsers(new DataLayer.User()).ToList();
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

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            var editDialog = new AdminDialog(null);
            editDialog.ShowDialog();
            RefreshList();
        }

        private void EditUserButton_Click(object sender, EventArgs e)
        {
            if(this.dataGridView.SelectedRows.Count == 1)
            {
                var editDialog = new AdminDialog(users[this.dataGridView.CurrentCell.RowIndex]);
                editDialog.ShowDialog();
                RefreshList();
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

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = false;
            this.Close();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            User searchCriteria = new User()
            {
                FirstName = this.firstNameTextBox.Text,
                LastName = this.lastnameTextBox.Text,
                Uname = this.loginTextBox.Text,
                Role = this.roleComboBox.Text
            };
            users = PersonelFacade.GetUsers(searchCriteria).ToList();
            this.RefreshList(false);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            this.lastnameTextBox.Clear();
            this.firstNameTextBox.Clear();
            this.roleComboBox.SelectedIndex = 0;
            this.loginTextBox.Clear();

            RefreshList();
        }
    }
}
