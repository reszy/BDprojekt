﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UserRole
    {
        public static readonly UserRole ADMIN = new UserRole("Admin", Type.Admin);
        public static readonly UserRole DOCTOR = new UserRole("Doctor", Type.Doctor);
        public static readonly UserRole LABWORKER = new UserRole("LabWorker", Type.LabWorker);
        public static readonly UserRole LABMANAGER = new UserRole("LabManager", Type.LabManager);
        public static readonly UserRole RECEPTIONIST = new UserRole("Receptionist", Type.Receptionist);
        public static readonly UserRole EMPTY = new UserRole("", Type.Empty);

        public enum Type{ Admin, Doctor, LabWorker, Receptionist, LabManager, Empty }

        public static IEnumerable<UserRole> Values
        {
            get
            { 
                yield return ADMIN;
                yield return DOCTOR;
                yield return LABWORKER;
                yield return RECEPTIONIST;

            }
        }

        private readonly string name;
        private readonly Type type;

        UserRole(string name, Type type)
        {
            this.name = name;
            this.type = type;
        }

        public string Name { get { return name; } }

        public override string ToString()
        {
            return name;
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
            else if(s.ToLower() == "receptionist")
                return UserRole.RECEPTIONIST;
            return UserRole.EMPTY;
        }
    }
}
