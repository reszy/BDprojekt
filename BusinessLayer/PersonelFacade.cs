using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;
using System.Security.Cryptography;

namespace BusinessLayer
{
    public static class PersonelFacade
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
                    if (authUser.DateRetire == null || DateTime.Now.Date < authUser.DateRetire)
                    {
                        UserRole role = authUser.Role;
                        if (role == UserRole.EMPTY)
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
                if(result.Address != null)
                {
                    result.Address.City = user.Address.City;
                    result.Address.HouseNr = user.Address.HouseNr;
                    result.Address.PlaceNr = user.Address.PlaceNr;
                    result.Address.Phone = user.Address.Phone;
                    result.Address.Province = user.Address.Province;
                    result.Address.Street = user.Address.Street;
                    result.Address.ZipCode = user.Address.ZipCode;
                }
                else
                {
                    Address address = new Address
                    {
                        City = user.Address.City,
                        HouseNr = user.Address.HouseNr,
                        PlaceNr = user.Address.PlaceNr,
                        Phone = user.Address.Phone,
                        Province = user.Address.Province,
                        Street = user.Address.Street,
                        ZipCode = user.Address.ZipCode

                     };
                    result.Address = address;
                }

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

