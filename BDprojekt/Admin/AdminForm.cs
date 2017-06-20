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
        public AdminForm()
        {
            InitializeComponent();

            var users = AdministrationFacade.GetUsers(new DataLayer.User());

            this.dataGridView.DataSource = users;
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
        }

        internal User getUser()
        {
            var ucell = this.dataGridView.SelectedRows[0];

            User user = new User
            {
                Uname = ucell.Cells[0].Value.ToString(),
            };
            return user;
        }

        private void editUserButton_Click(object sender, EventArgs e)
        {
            if(this.dataGridView.SelectedRows.Count > 0)
            {
                var editDialog = new AdminDialog(this);
                editDialog.ShowDialog();
            }
        }
    }
}
