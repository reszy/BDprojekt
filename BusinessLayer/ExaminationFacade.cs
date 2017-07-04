using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using BusinessLayer.Enum;

namespace BusinessLayer
{
    public static class ExaminationFacade
    {
        public static IQueryable<LaboratoryExamination> GetLaboratoryExamination(ExaminationStatus status)
        {
            var dc = new DataClassesClinicDataContext();

            var result = from e in dc.LaboratoryExaminations
                         where
                            (String.IsNullOrEmpty(status.Text) || e.Status.StartsWith(status.Text))
                         orderby e.OrderDate descending
                         select e;

            return result;
        }

        public static void UpdateLaboratoryExamination(LaboratoryExamination examination)
        {
            var dc = new DataClassesClinicDataContext();

            var result = (from e in dc.LaboratoryExaminations
                          where e.LaboratoryExaminationId == examination.LaboratoryExaminationId
                          select e).SingleOrDefault();

            if (result != null)
            {
                result.Status = examination.Status;

                if (examination.EndCancelDate != null || examination.EndCancelDate != DateTime.MinValue)
                {
                    result.EndCancelDate = examination.EndCancelDate;
                    result.Result = examination.Result;
                }

                if(examination.ApprovalCancelDate != null || examination.ApprovalCancelDate != DateTime.MinValue)
                {
                    result.MenagerAttention = examination.MenagerAttention;
                    result.ApprovalCancelDate = examination.ApprovalCancelDate;
                }

                dc.SubmitChanges();
            }
        }

        public static void AddNewLaboratoryExamination(LaboratoryExamination examination)
        {
            var dc = new DataClassesClinicDataContext();

            dc.LaboratoryExaminations.InsertOnSubmit(examination);
            dc.SubmitChanges();
        }

        public static IQueryable<PhysicalExamination> GetPhysicalExamination()
        {
            var dc = new DataClassesClinicDataContext();

            var result = from e in dc.PhysicalExaminations
                         select e;

            return result;
        }

        public static void AddNewPhysicalExamination(PhysicalExamination examination)
        {
            var dc = new DataClassesClinicDataContext();

            dc.PhysicalExaminations.InsertOnSubmit(examination);
            dc.SubmitChanges();
        }
    }
}
