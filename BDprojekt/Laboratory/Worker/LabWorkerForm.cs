using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class LabWorkerForm : Form
    {
        private LoginScreen mainForm;

        public LabWorkerForm(LoginScreen mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }
    }
}
