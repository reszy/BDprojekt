using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;


namespace BusinessLayer
{
    public static class VisitsFacade
    {
        public static IQueryable<Visit> GetVisits(Visit searchCrit)
        {
            var dc = new DataClassesClinicDataContext();

            var result = from v in dc.Visits
                         where
                          ((searchCrit.PatientId == 0) || v.PatientId == searchCrit.PatientId)
                          &&
                          ((searchCrit.DoctorId == 0) || v.DoctorId == searchCrit.DoctorId)
                          &&
                          ((searchCrit.DateOfRegistration == null) || (searchCrit.DateOfRegistration == DateTime.MinValue) || v.DateOfRegistration == searchCrit.DateOfRegistration)
                         orderby v.DateOfRegistration descending
                         select v;

            return result;
        }

        public static void AddNewVisit(Visit visit)
        {
            var dc = new DataClassesClinicDataContext();

            dc.Visits.InsertOnSubmit(visit);
            dc.SubmitChanges();
        } 

        public static void UpdateVisit(Visit visit)
        {
            var dc = new DataClassesClinicDataContext();

            var result = (from v in dc.Visits
                          where v.VisitId == visit.VisitId
                          select v).SingleOrDefault();

            if (result != null)
            {
                result.DoctorId = visit.DoctorId;
                result.Description = visit.Description;
                result.Diagnosis = visit.Diagnosis;
                result.Status = visit.Status;
                result.DateOfRegistration = visit.DateOfRegistration;
                result.EndCancelDate = visit.EndCancelDate;

                dc.SubmitChanges();
            }
        }

        public static void CancelVisit(int VisitId)
        {
            var dc = new DataClassesClinicDataContext();

            var result = (from v in dc.Visits
                          where v.VisitId == VisitId
                          select v).SingleOrDefault();
            if (result != null)
            {
                result.Status = VisitStatus.CANCEL.Text;

                dc.SubmitChanges();
            }
        }

        public struct DoctorVisits
        {
            public string name;
            public int count;
        }

        public static IQueryable<DoctorVisits> GetVisitDoctorCount(DateTime startDate, DateTime endDate)
        {
            LinkedList<DoctorVisits> list = new LinkedList<DoctorVisits>();


            var doctors = PersonelFacade.GetUsers(
                new User
                {
                    Role = UserRole.DOCTOR.Text
                });


            var dc = new DataClassesClinicDataContext();

            foreach (var doctor in doctors)
            {
                int visitCount = (from v in dc.Visits
                             where 
                                (v.DoctorId == doctor.PersonId) && 
                                (v.DateOfRegistration >= startDate && v.DateOfRegistration <= endDate)
                                  select v).Count();    
                list.AddLast(new DoctorVisits { count = visitCount, name = (doctor.FirstName + " " + doctor.LastName) });
            }

            return list.AsQueryable();
        }
    }
}
