﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public static class PatientsFacade
    {
        public static IQueryable<Patient> GetPatients(Patient searchCrit)
        {
            var dc = new DataClassesClinicDataContext();

            var result = from p in dc.Patients
                         where
                            (String.IsNullOrEmpty(searchCrit.FirstName) || p.FirstName.StartsWith(searchCrit.FirstName))
                            &&
                            (String.IsNullOrEmpty(searchCrit.LastName) || p.LastName.StartsWith(searchCrit.LastName))
                            &&
                            (String.IsNullOrEmpty(searchCrit.Pesel) || p.Pesel.StartsWith(searchCrit.Pesel))
                         select p;

            return result;
        }

        public static void AddNewPatient(Patient patient)
        {
            var dc = new DataClassesClinicDataContext();

            dc.Patients.InsertOnSubmit(patient);
            dc.SubmitChanges();
        }

        public static void UpdatePatient(Patient patient)
        {
            var dc = new DataClassesClinicDataContext();

            var result = (from p in dc.Patients
                          where p.PatientId == patient.PatientId
                          select p).SingleOrDefault();

            if (result != null)
            {
                result.BirthdayDate = patient.BirthdayDate;
                result.FirstName = patient.FirstName;
                result.LastName = patient.LastName;
                result.Sex = patient.Sex;
                result.Pesel = patient.Pesel;
                result.NIP = patient.NIP;
                result.Insurance = patient.Insurance;

                dc.SubmitChanges();
            }
        }
    }
}
