using DataLayer;
using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer.Admin
{
    public partial class AdminDialog : Form
    {
        private bool update;
        private User editedUser;

        public AdminDialog(User user)
        {
            InitializeComponent();
            editedUser = user;

            if (editedUser != null)
            {
                update = true;
                this.firstNameTextBox.Text = editedUser.FirstName;
                this.lastNameTextBox.Text = editedUser.LastName;
                this.userNameTextBox.Text = editedUser.Uname;
                this.passwordTextBox.Text = "";
                if (editedUser.DateRetire != null)
                {
                    this.accountStateDateTimePicker.Checked = true;
                    this.accountStateDateTimePicker.Value = Convert.ToDateTime(editedUser.DateRetire);
                }
                else
                {
                    this.accountStateDateTimePicker.Checked = false;
                }
            }
            else
            {
                update = false;
                this.editedUser = new User();
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            editedUser.FirstName = this.firstNameTextBox.Text;
            editedUser.LastName = this.lastNameTextBox.Text;
            editedUser.Uname = this.userNameTextBox.Text;
            editedUser.Password = this.passwordTextBox.Text;
            editedUser.Role = this.roleComboBox.Text;
            if (this.accountStateDateTimePicker.Checked)
            {
                editedUser.DateRetire = this.accountStateDateTimePicker.Value;
            }
            else
            {
                editedUser.DateRetire = null;
            }


            if (update)
            {
                AdministrationFacade.UpdateUserData(editedUser);
            }
            else
            {
                AdministrationFacade.AddNewUser(editedUser);
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
