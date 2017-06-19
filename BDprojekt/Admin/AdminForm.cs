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
            //this.dataGridView.SelectedRows
        }
    }
}
