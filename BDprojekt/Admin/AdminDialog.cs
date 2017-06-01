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
        private AdminPanel mainForm;

        public AdminDialog(AdminPanel mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
    }
}
