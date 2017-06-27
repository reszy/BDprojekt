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
                            (String.IsNullOrEmpty(searchCrit.Status) || e.FirstName.StartsWith(searchCrit.Status))
                         select e;

            return result;
        }
    }
}
