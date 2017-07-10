using DataLayer;
using BusinessLayer;
using BusinessLayer.Enum;
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
        private bool update;

        private User editedUser;

        public AdminDialog(User user)
        {
            InitializeComponent();
            
            var roles = UserRole.Values.ToList();
            roles.Insert(0, UserRole.EMPTY);
            this.roleComboBox.DataSource = roles;

            editedUser = user;

            if (editedUser != null)
            {
                update = true;
                
                this.firstNameTextBox.Text = editedUser.FirstName;
                this.lastNameTextBox.Text = editedUser.LastName;
                this.userNameTextBox.Text = editedUser.Uname;                
                this.passwordTextBox.Text = "";

                UserRole.Type index = ((UserRole)editedUser.Role).ToEnum();
                this.roleComboBox.SelectedIndex = index == UserRole.Type.EMPTY ? 0 : (int)index+1;

                if (editedUser.DateRetire != null)
                {
                    this.accountStateDateTimePicker.Checked = true;
                    this.accountStateDateTimePicker.Value = Convert.ToDateTime(editedUser.DateRetire);
                }
                else
                {
                    this.accountStateDateTimePicker.Checked = false;
                }

                if(editedUser.Address != null)
                {
                    this.cityTextBox.Text = editedUser.Address.City;
                    this.houseNoTextBox.Text = editedUser.Address.HouseNr;
                    this.placeNoTextBox.Text = editedUser.Address.PlaceNr;
                    this.phoneNoTextBox.Text = editedUser.Address.Phone;
                    this.provinceTextBox.Text = editedUser.Address.Province;
                    this.streetTextBox.Text = editedUser.Address.Street;
                    this.zipCodeTextBox.Text = editedUser.Address.ZipCode;
                }
            }
            else
            {
                update = false;
                this.editedUser = new User();
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            editedUser.FirstName = this.firstNameTextBox.Text;
            editedUser.LastName = this.lastNameTextBox.Text;
            editedUser.Uname = this.userNameTextBox.Text;
            editedUser.Password = this.passwordTextBox.Text;
            editedUser.Role = this.roleComboBox.Text;
            if (this.accountStateDateTimePicker.Checked)
            {
                editedUser.DateRetire = this.accountStateDateTimePicker.Value;
            }
            else
            {
                editedUser.DateRetire = null;
            }

            if (editedUser.Address != null)
            {
                editedUser.Address.City = this.cityTextBox.Text;
                editedUser.Address.HouseNr = this.houseNoTextBox.Text;
                editedUser.Address.PlaceNr = this.placeNoTextBox.Text;
                editedUser.Address.Phone = this.phoneNoTextBox.Text;
                editedUser.Address.Province = this.provinceTextBox.Text;
                editedUser.Address.Street = this.streetTextBox.Text;
                editedUser.Address.ZipCode = this.zipCodeTextBox.Text;
            }

            if (update)
            {            
                
                if( this.cityTextBox.Text != "" || 
                    this.houseNoTextBox.Text != "" ||
                    this.placeNoTextBox.Text != "" ||
                    this.phoneNoTextBox.Text != "" ||
                    this.provinceTextBox.Text != "" ||
                    this.streetTextBox.Text != "" ||
                    this.zipCodeTextBox.Text != "" )
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

                    editedUser.Address = address;                    
                }

                PersonelFacade.UpdateUserData(editedUser);
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

                editedUser.Address = address;
                PersonelFacade.AddNewUser(editedUser);        
            }

            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
