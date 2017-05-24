using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDprojekt.Admin
{
    public partial class AddUserDialog : Form
    {
        private AdminPanel mainForm;

        public AddUserDialog(AdminPanel mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
    }
}
