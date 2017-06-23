using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    class VisitsFacade
    {
        public IQueryable<Visit> GetVisits(Visit searchCrit)
        {
            var dc = new DataClassesClinicDataContext();

            var result = from v in dc.Visits
                         where
                          ((searchCrit.PatientId == 0) || v.PatientId == searchCrit.PatientId)
                          &&
                          ((searchCrit.DoctorId == 0) || v.DoctorId == searchCrit.DoctorId)
                          &&
                          ((searchCrit.DateOfRegistration == null) || v.DateOfRegistration == searchCrit.DateOfRegistration)
                         orderby v.DateOfRegistration descending
                         select v;

            return result;
        }

        public void AddNewVisit(Visit visit)
        {
            var dc = new DataClassesClinicDataContext();

            dc.Visits.InsertOnSubmit(visit);
            dc.SubmitChanges();
        } 

        public void UpdateVisit(Visit visit)
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

        public void CancelVisit(int VisitId)
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
    }
}
