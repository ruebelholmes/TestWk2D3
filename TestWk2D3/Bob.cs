using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWk2D3
{
    public partial class Bob
    {
        public string hey(string remark)
        {
            if (Silence(remark))
                return "Fine. Be that way!";

            if (Question(remark))
                return "Sure.";

            if (Yelling(remark))
                return "Whoa, chill out!";

            return "Whatever.";
        }

        public bool Silence(string remark)
        {
            return remark == null || remark.Trim() == " ";
        }

        public bool Question(string remark) => remark.EndsWith("?");

        public bool Yelling(string remark)
        {
            if (remark.Any(t => char.IsDigit(t) && remark.EndsWith("!")))
            { 
                return true;
            }
            return remark == ReplaceNumbers(remark.ToUpper());
        }

        private string ReplaceNumbers(string remark)
        {
            for (int i = 0; i < remark.Length; i++)
            {
                if (char.IsDigit(remark[i]))
                {
                    remark = remark.Replace(remark[i], '*');
                }
            }

            return remark;
        }

        
    }
}
