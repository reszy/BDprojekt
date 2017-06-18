using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

namespace BusinessLayer
{
    class AdministrationFacade
    {
        public IQueryable<User> GetUsers(User searchCrit)
        {
            using (var dc = new DataClassesClinicDataContext())
            {
                var result = from u in dc.Users
                             where
                                  u.FirstName.StartsWith(searchCrit.FirstName) ||
                                  u.LastName.StartsWith(searchCrit.LastName) ||
                                  u.PersonId == searchCrit.PersonId                                 
                             orderby u.PersonId descending
                             select new User
                             {
                                 PersonId = u.PersonId,
                                 Uname = u.Uname,
                                 Role = u.Role,
                                 FirstName = u.FirstName,
                                 LastName = u.LastName,
                                 DateRetire = u.DateRetire
                             };

                return result;
            }
        }

        public void UpdateUserData(User user)
        {
            using (var dc = new DataClassesClinicDataContext())
            {
                var result = (from u in dc.Users
                              where u.PersonId == user.PersonId
                              select u).SingleOrDefault();

                if (result != null)
                {
                    result.LastName = user.LastName;
                    result.FirstName = user.FirstName;
                    result.Role = user.Role;
                    result.Uname = user.Uname;
                    result.Password = user.Password;
                    dc.SubmitChanges();
                }
            }
        }
    }


}
