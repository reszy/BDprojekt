﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BusinessLayer;
using DataLayer;

namespace BDprojekt.Register
{
    public partial class RegisterDialog : Form
    {
        List<User> doctors;
        List<string> doctorNames;
        int registrarId;
        int patientId;

        public RegisterDialog(int patientId, int registrarId)
        {
            InitializeComponent();
            this.registrarId = registrarId;
            this.patientId = patientId;
            doctors = PersonelFacade.GetUsers(new User { Role = UserRole.DOCTOR.ToString() }).ToList();
            doctorNames = new List<string>();
            foreach (var doctor in doctors)
            {
                doctorNames.Add(doctor.LastName + " " + doctor.FirstName);
            }
            this.comboBox1.DataSource = doctorNames;
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
                return;

            var many = PersonelFacade.GetUsers(new User { PersonId = this.registrarId }).ToList();
            Visit visit = new Visit
            {
                PatientId = this.patientId,
                ReceptionistId = this.registrarId,
                DoctorId = doctors[comboBox1.SelectedIndex].PersonId,
                Description = "",
                Status = VisitStatus.REGISTER.ToString(),
                DateOfRegistration = dateTimePicker1.Value
            };

            VisitsFacade.AddNewVisit(visit);
            this.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
