using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Status
    {
        public static readonly Status REGISTER = new Status("Register", Type.REGISTER);
        public static readonly Status CANCEL = new Status("Cancel", Type.CANCEL);
        public static readonly Status FINISH = new Status("Finish", Type.FINISH);
        public static readonly Status READY = new Status("Ready", Type.READY);


        public enum Type { REGISTER, CANCEL, FINISH, READY }

        public static IEnumerable<Status> Values
        {
            get
            {
                yield return REGISTER;
                yield return CANCEL;
                yield return FINISH;
                yield return READY;
            }
        }

        private readonly string text;
        private readonly Type type;

        Status(string name, Type type)
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

        public static implicit operator Status(string s)
        {
            if (s.ToLower() == "register")
                return Status.REGISTER;
            else if (s.ToLower() == "cancel")
                return Status.CANCEL;
            else if (s.ToLower() == "finish")
                return Status.FINISH;
            else if (s.ToLower() == "ready")
                return Status.READY;
            return Status.CANCEL;
        }
    }
}

