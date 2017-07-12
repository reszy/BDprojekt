using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Enum
{
    public class ExaminationStatus
    {
        public static readonly ExaminationStatus PENDING = new ExaminationStatus("Pending", Type.PENDING);
        public static readonly ExaminationStatus CANCEL_MAN = new ExaminationStatus("Cancel_Man", Type.CANCEL_MAN);
        public static readonly ExaminationStatus CANCEL_WOR = new ExaminationStatus("Cancel_Wor", Type.CANCEL_WOR);
        public static readonly ExaminationStatus READY = new ExaminationStatus("Finish", Type.READY);
        public static readonly ExaminationStatus TOCONFIRM = new ExaminationStatus("ToConfirm", Type.TOCONFIRM);


        public enum Type { PENDING, CANCEL_MAN, CANCEL_WOR, READY, TOCONFIRM }

        public static IEnumerable<ExaminationStatus> Values
        {
            get
            {
                yield return PENDING;
                yield return CANCEL_MAN;
                yield return CANCEL_WOR;
                yield return READY;
                yield return TOCONFIRM;
            }
        }

        private readonly string text;
        private readonly Type type;

        ExaminationStatus(string name, Type type)
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

        public static implicit operator ExaminationStatus(string s)
        {
            if (s.ToLower() == "pending")
                return ExaminationStatus.PENDING;
            else if (s.ToLower() == "cancel_men")
                return ExaminationStatus.CANCEL_MAN;
            else if (s.ToLower() == "cancel_wor")
                return ExaminationStatus.CANCEL_WOR;
            else if (s.ToLower() == "ready")
                return ExaminationStatus.READY;
            else if (s.ToLower() == "toconfirm")
                return ExaminationStatus.TOCONFIRM;
            return ExaminationStatus.CANCEL_MAN;
        }
    }
}

