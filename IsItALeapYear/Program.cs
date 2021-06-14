using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsItALeapYear
{
    public class Program
    {
        static void Main(string[] args)
        {
        }

        public bool IsItALeapYear(int var)
        {

            return false;
        }

        public bool Year_1996_Is_a_leap_year(int var1)
        {

            return true;
        }

        public bool Year_1900_is_not_a_leap_year(int var2)
        {
            if (var2 % 100 == 0)
            {
                return false;
            }
            else {
                return true;
            }
            
        }

        public bool Year_2000_is_a_leap_year(int var3)
        {
            if (var3 % 400 == 0)
            {
                return false;
            }
            else if (var3 % 100 == 0)
            {
                return true;
            }
            else {
                return false; 
            }
        }
    }
}
