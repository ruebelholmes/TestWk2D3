using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWk2D3
{
    class Program
    {
        static void Main(string[] args)
        {
            Bob bob = new Bob();
            string remark = "";
        }
    }

    public class Bob
    {
        public string Hey(string remark)
        {
            if (remark.EndsWith("!"))
            {
                return "Whoa, chill out!";
            }

            return "Whatever.";
        }







    }
}
