using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public static class LaboratoryFacade
    {
        public static IQueryable<LaboratoryExamination> GetLaboratoryExamination(LaboratoryExamination searchCrit)
        {
            var dc = new DataClassesClinicDataContext();

            var result = from e in dc.LaboratoryExaminations
                         where
                            (String.IsNullOrEmpty(searchCrit.Status) || e.Status.StartsWith(searchCrit.Status))
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
    }
}
