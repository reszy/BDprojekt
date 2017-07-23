using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enum
{
    public class VisitStatus
    {
        public static readonly VisitStatus REGISTER = new VisitStatus("Register", Type.REGISTER);
        public static readonly VisitStatus CANCEL = new VisitStatus("Cancel", Type.CANCEL);
        public static readonly VisitStatus FINISH = new VisitStatus("Finish", Type.FINISH);
        public static readonly VisitStatus INPROGRESS = new VisitStatus("InProgress", Type.INPROGRESS);

        public enum Type { REGISTER, CANCEL, FINISH, INPROGRESS }

        public static IEnumerable<VisitStatus> Values
        {
            get
            {
                yield return REGISTER;
                yield return CANCEL;
                yield return FINISH;
                yield return INPROGRESS;
            }
        }

        private readonly string text;
        private readonly Type type;

        VisitStatus(string name, Type type)
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

        public static implicit operator VisitStatus(string s)
        {
            string text = s.ToLower();

            if (text == "register")
                return VisitStatus.REGISTER;
            else if (text == "cancel")
                return VisitStatus.CANCEL;
            else if (text == "finish")
                return VisitStatus.FINISH;
            else if (text == "inprogress")
                return VisitStatus.INPROGRESS;
            return VisitStatus.CANCEL;
        }
    }
}

