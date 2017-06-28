using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enum
{
    public class UserRole
    {
        public static readonly UserRole ADMIN = new UserRole("Admin", Type.ADMIN);
        public static readonly UserRole DOCTOR = new UserRole("Doctor", Type.DOCTOR);
        public static readonly UserRole LABWORKER = new UserRole("LabWorker", Type.LABWORKER);
        public static readonly UserRole LABMANAGER = new UserRole("LabManager", Type.LABMANAGER);
        public static readonly UserRole RECEPTIONIST = new UserRole("Receptionist", Type.RECEPTIONIST);
        public static readonly UserRole EMPTY = new UserRole("", Type.EMPTY);

        public enum Type{ ADMIN, DOCTOR, LABWORKER, LABMANAGER, RECEPTIONIST, EMPTY }

        public static IEnumerable<UserRole> Values
        {
            get
            { 
                yield return ADMIN;
                yield return DOCTOR;
                yield return LABWORKER;
                yield return LABMANAGER;
                yield return RECEPTIONIST;
            }
        }

        private readonly string text;
        private readonly Type type;

        UserRole(string name, Type type)
        {
            this.text = name;
            this.type = type;
        }

        public string Text { get { return text; } }

        public override string ToString()
        {
            return text;
        }

        public Type ToEnum()
        {           
            return type;
        }

        public static implicit operator UserRole(string s)
        {
            if (s.ToLower() == "admin")
                return UserRole.ADMIN;
            else if (s.ToLower() == "doctor")
                return UserRole.DOCTOR;
            else if(s.ToLower() == "labworker")
                return UserRole.LABWORKER;
            else if (s.ToLower() == "labmanager")
                return UserRole.LABMANAGER;
            else if(s.ToLower() == "receptionist")
                return UserRole.RECEPTIONIST;
            return UserRole.EMPTY;
        }
    }
}
