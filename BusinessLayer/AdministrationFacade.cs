using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    public static class AdministrationFacade
    {
        public static IQueryable GetUsers(User searchCrit)
        {
            var dc = new DataClassesClinicDataContext();

            var result = from u in dc.Users
                         where
                             (String.IsNullOrEmpty(searchCrit.FirstName) || u.FirstName.StartsWith(searchCrit.FirstName))
                             &&
                             (String.IsNullOrEmpty(searchCrit.LastName) || u.LastName.StartsWith(searchCrit.LastName))
                             &&
                             (String.IsNullOrEmpty(searchCrit.Uname) || u.Uname.StartsWith(searchCrit.Uname))
                         select new { u.Uname, u.FirstName, u.LastName, u.Role, u.DateRetire };         
            return result;            
        }

        public static void UpdateUserData(User user)
        {
            using (var dc = new DataClassesClinicDataContext())
            {
                var result = (from u in dc.Users
                              where String.IsNullOrEmpty(user.Uname) || u.Uname == user.Uname
                              select u).SingleOrDefault();

                if (result != null)
                {
                    result.LastName = user.LastName;
                    result.FirstName = user.FirstName;
                    result.Role = user.Role;                    
                    result.DateRetire = user.DateRetire;                    
                    if (!String.IsNullOrEmpty(user.Password))
                        result.Password = user.Password;

                    dc.SubmitChanges();
                }
            }
        }
    }


}
