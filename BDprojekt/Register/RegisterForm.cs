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

namespace PresentationLayer.Clinic
{
    public partial class RegisterForm : Form
    {
        private Form mainForm;
        private bool logout = false;

        private List<Patient> patients;
        private List<Visit> visits;
        RegistrationFacade rFacade;

        public RegisterForm(Form mainForm)
        {
            this.mainForm = mainForm;

            InitializeComponent();
            this.rFacade = new RegistrationFacade();

            this.refreshPatientList();
        }

        private void refreshPatientList()
        {
            patients = rFacade.GetPatients(new DataLayer.Patient()).ToList();

            this.patientsDataGrid.DataSource = null;
            this.patientsDataGrid.DataSource = patients;
            this.patientsDataGrid.Refresh();
        }

        private void refreshVisitList(int patientId)
        {
            visits = rFacade.GetVisits(patientId).ToList();

            this.visitDataGrid.DataSource = null;
            this.visitDataGrid.DataSource = visits;
            this.visitDataGrid.Refresh();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = true;
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logout = false;
            this.Close();
        }

        private void RegisterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if(logout)
                {
                    mainForm.Show();
                }
                else
                {
                    Application.Exit();
                }
            }
        }
    }
}
