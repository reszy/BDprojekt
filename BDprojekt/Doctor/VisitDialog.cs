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

namespace BDprojekt.Doctor
{
    public partial class VisitDialog : Form
    {
        Visit visit;
        int doctorId;
        public VisitDialog(Visit visit, int doctorId)
        {
            this.visit = visit;
            this.doctorId = doctorId;
            InitializeComponent();
        }
    }
}
