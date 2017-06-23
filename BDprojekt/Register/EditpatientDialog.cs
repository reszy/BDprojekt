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
    public partial class EditPatientDialog : Form
    {
        RegistrationFacade rFacade;
        Patient editedPatient;

        bool update = false;

        public EditPatientDialog(Patient patient)
        {
            this.editedPatient = patient;
            rFacade = new RegistrationFacade();
            InitializeComponent();
            if (editedPatient != null)
            {
                update = true;
                this.firstnameTextBox.Text = editedPatient.FirstName;
                this.lastnameTextBox.Text = editedPatient.LastName;
                this.peselTextBox.Text = editedPatient.Pesel;
            }
            else
            {
                update = false;
                this.editedPatient = new Patient();
            }

        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            editedPatient.FirstName = this.firstnameTextBox.Text;
            editedPatient.LastName = this.lastnameTextBox.Text;
            editedPatient.Pesel = this.peselTextBox.Text;
            if (update)
            {
                this.rFacade.UpdatePatient(editedPatient);
            }
            else
            {
                this.rFacade.AddNewPatient(editedPatient);
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
