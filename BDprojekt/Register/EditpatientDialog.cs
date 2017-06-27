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
        Patient editedPatient;

        bool update = false;

        public EditPatientDialog(Patient patient)
        {
            this.editedPatient = patient;            
            InitializeComponent();
            if (editedPatient != null)
            {
                update = true;
                this.firstnameTextBox.Text = editedPatient.FirstName;
                this.lastnameTextBox.Text = editedPatient.LastName;
                this.peselTextBox.Text = editedPatient.Pesel;
                this.nipTextBox.Text = editedPatient.NIP;
                this.insuranceCheckBox.Checked = (editedPatient.Insurance == 'Y');
                    this.sexComboBox.Text = this.editedPatient.Sex.ToString();
                if(editedPatient.BirthdayDate != null)
                {
                    this.birthdatePicker.Checked = true;
                    this.birthdatePicker.Value = Convert.ToDateTime(editedPatient.BirthdayDate);
                }
                else
                {
                    this.birthdatePicker.Checked = false;
                }
            }
            else
            {
                update = false;
                this.editedPatient = new Patient();
            }

            if (editedPatient.Address != null)
            {
                this.cityTextBox.Text = editedPatient.Address.City;
                this.houseNoTextBox.Text = editedPatient.Address.HouseNr;
                this.placeNoTextBox.Text = editedPatient.Address.PlaceNr;
                this.phoneNoTextBox.Text = editedPatient.Address.Phone;
                this.provinceTextBox.Text = editedPatient.Address.Province;
                this.streetTextBox.Text = editedPatient.Address.Street;
                this.zipCodeTextBox.Text = editedPatient.Address.ZipCode;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            editedPatient.FirstName = this.firstnameTextBox.Text;
            editedPatient.LastName = this.lastnameTextBox.Text;
            editedPatient.Pesel = this.peselTextBox.Text;
            editedPatient.NIP = this.nipTextBox.Text;
            editedPatient.Sex = this.sexComboBox.Text[0];
            editedPatient.Insurance = this.insuranceCheckBox.Checked ? 'Y' : 'N';

            if (this.birthdatePicker.Checked)
            {
                editedPatient.BirthdayDate = this.birthdatePicker.Value;
            }
            else
            {
                editedPatient.BirthdayDate = null;
            }


            if (editedPatient.Address != null)
            {
                editedPatient.Address.City = this.cityTextBox.Text;
                editedPatient.Address.HouseNr = this.houseNoTextBox.Text;
                editedPatient.Address.PlaceNr = this.placeNoTextBox.Text;
                editedPatient.Address.Phone = this.phoneNoTextBox.Text;
                editedPatient.Address.Province = this.provinceTextBox.Text;
                editedPatient.Address.Street = this.streetTextBox.Text;
                editedPatient.Address.ZipCode = this.zipCodeTextBox.Text;
            }

            if (update)
            {
                PatientsFacade.UpdatePatient(editedPatient);
            }
            else
            {
                Address address = new Address
                {
                    City = this.cityTextBox.Text,
                    HouseNr = this.houseNoTextBox.Text,
                    PlaceNr = this.placeNoTextBox.Text,
                    Phone = this.phoneNoTextBox.Text,
                    Province = this.provinceTextBox.Text,
                    Street = this.streetTextBox.Text,
                    ZipCode = this.zipCodeTextBox.Text

                };

                editedPatient.Address = address;
                PatientsFacade.AddNewPatient(editedPatient);
            }

            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
