using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DataLayer;
using BusinessLayer;

namespace BDprojekt.Register
{
    public partial class EditpatientDialog : Form
    {
        RegistrationFacade rFacade;

        public EditpatientDialog()
        {
            InitializeComponent();
        }
    }
}
