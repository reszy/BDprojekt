using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public class RegistrationFacade
    {
        public IQueryable GetPatients()
        {
            using (var dc = new DataClassesClinicDataContext())
            {
                var result = from p in dc.Patients
                             select p;

                return result;
            }
        }

        public IQueryable GetVisit(Patient searchCrit)
        {
            using (var dc = new DataClassesClinicDataContext())
            {
                var result = from v in dc.Visits
                             where v.PatientId == searchCrit.PatientId
                             select v;

                return result;
            }
        }

        public void AddNewPatient(Patient patient)
        {
            using (var dc = new DataClassesClinicDataContext())
            {
                dc.Patients.InsertOnSubmit(patient);
                dc.SubmitChanges();
            }
        }

        public void UpdatePatient(Patient patient)
        {
            using (var dc = new DataClassesClinicDataContext())
            {
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
}
