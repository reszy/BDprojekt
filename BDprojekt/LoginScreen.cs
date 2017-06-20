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

namespace PresentationLayer
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            UserRole role;

            try
            {
                role = AdministrationFacade.MakeLogin(
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
                return;
            }

            this.Hide();
            this.passwordTextBox.Text = "";
            this.userNameTextBox.Text = "";

            switch (role.ToEnum())
            {
                case UserRole.Type.ADMIN:
                    var a = new Admin.AdminForm(this);
                    a.Show();
                    break;
                case UserRole.Type.DOCTOR:
                    var d = new DoctorPanel();
                    d.Show();          
                    break;
                case UserRole.Type.LABWORKER:
                    var l = new Laboratory();
                    l.Show();
                    break;
                case UserRole.Type.RECEPTIONIST:
                    var r = new RegisterForm(this);
                    r.Show();
                    break;
            }                      
        }

        private void userNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Enter)
            {
                this.loginButton_Click(this, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void passwordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.loginButton_Click(this, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
