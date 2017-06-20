using DataLayer;
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
        private AdminForm mainForm;
        private bool update;
        private User editedUser;

        public AdminDialog(AdminForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();

            if((editedUser = this.mainForm.getUser()) != null)
            {
                update = true;
                this.firstNameTextBox.Text = editedUser.FirstName;
                this.lastNameTextBox.Text = editedUser.LastName;
                this.loginTextBox.Text = editedUser.Uname;
            }
            else
            {
                update = false;
                this.editedUser = new User();
            }

        }
    }
}
