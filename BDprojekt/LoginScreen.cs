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
using BusinessLayer.Exceptions;
using PresentationLayer.Clinic; // TODO - Give the same namespace
using BusinessLayer.Enum;
using DataLayer;

namespace PresentationLayer
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private int loggedId = -1;

        internal int LoggedId { get => loggedId; }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            User authUser;

            try
            {
                authUser = PersonelFacade.MakeLogin(
                    userNameTextBox.Text,
                    passwordTextBox.Text);
            }
            catch (LoginException exception)
            {
                MessageBox.Show(
                    exception.Message,
                    "Błąd logowania", 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );                
                passwordTextBox.Clear();
                return;
            }

            this.loggedId = authUser.PersonId;

            this.Hide();
            this.passwordTextBox.Text = "";
            this.userNameTextBox.Text = "";


            UserRole role = authUser.Role;
            switch (role.ToEnum())
            {
                case UserRole.Type.ADMIN:
                    var a = new Admin.AdminForm(this);
                    a.Show();
                    break;
                case UserRole.Type.DOCTOR:
                    var d = new DoctorPanel(this);
                    d.Show();          
                    break;
                case UserRole.Type.LABMANAGER:
                    var lm = new LabManagerForm(this);
                    lm.Show();
                    break;
                case UserRole.Type.LABWORKER:
                    var lw = new LabWorkerForm(this);
                    lw.Show();
                    break;
                case UserRole.Type.RECEPTIONIST:
                    var r = new RegisterForm(this);
                    r.Show();
                    break;
                default:
                    break;
            }                      
        }

        private void UserNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                this.LoginButton_Click(this, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void PasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.LoginButton_Click(this, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
