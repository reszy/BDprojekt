using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Security.Cryptography;

namespace BusinessLayer
{
    public static class AdministrationFacade
    {
        private static string Hash(string input)
        {
            var hash = (new SHA1Managed()).ComputeHash(Encoding.UTF8.GetBytes(input));
            return string.Join("", hash.Select(b => b.ToString("x2")).ToArray());
        }

        public static UserRole MakeLogin(String userName, String password)
        {  
            var users = GetUsers(
                new User { Uname = userName }
                );

            if (users.Count() == 1)
            {
                User authUser = users.SingleOrDefault();

                if (authUser.Password == Hash(password) && authUser.Uname == userName)
                {
                    if (DateTime.Now.Date < authUser.DateRetire || authUser.DateRetire == null)
                    {
                        UserRole role = authUser.Role;
                        if(role == UserRole.EMPTY)
                            throw new Exceptions.LoginException("Temu kontu nie przydzelono roli");
                        else
                            return role;
                    }                       
                    else                    
                        throw new Exceptions.LoginException("To konto wygasło");
                    
                }

            }
            throw new Exceptions.LoginException("Niepoprawne dane logowania");
        }


        public static IQueryable<User> GetUsers(User searchCrit)
        {
            var dc = new DataClassesClinicDataContext();
      
            var result = from u in dc.Users
                         where
                            (String.IsNullOrEmpty(searchCrit.Role) || u.Role.StartsWith(searchCrit.Role))
                            &&
                            (String.IsNullOrEmpty(searchCrit.FirstName) || u.FirstName.StartsWith(searchCrit.FirstName))
                            &&
                            (String.IsNullOrEmpty(searchCrit.LastName) || u.LastName.StartsWith(searchCrit.LastName))
                            &&
                            (String.IsNullOrEmpty(searchCrit.Uname) || u.Uname.StartsWith(searchCrit.Uname))
                         select u;
            return result;            
        }

        public static void UpdateUserData(User user)
        {
            var dc = new DataClassesClinicDataContext();
    
            var result = (from u in dc.Users
                          where u.PersonId == user.PersonId
                          select u).SingleOrDefault();

            if (result != null)
            {
                result.LastName = user.LastName;
                result.FirstName = user.FirstName;
                result.Uname = user.Uname;
                result.Role = user.Role;
                result.DateRetire = user.DateRetire;
                if (!String.IsNullOrEmpty(user.Password))
                    result.Password = Hash(user.Password);

                dc.SubmitChanges();
            }
        }

        public static void AddNewUser(User user)
        {
            var dc = new DataClassesClinicDataContext();

            user.Password = Hash(user.Password);

            dc.Users.InsertOnSubmit(user);
            dc.SubmitChanges();
        }
    }
}
