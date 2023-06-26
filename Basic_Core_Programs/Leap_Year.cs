using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class Leap_Year
    {
        public void Check_Leap_Year()
        {
            Console.WriteLine("Enter a year you want to check");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year % 400 == 0)
            {
                Console.WriteLine($"The year {year} is a Leap year");
            }
            else if (year % 100 == 0)
            {
                Console.WriteLine($"The year {year} is NOT a Leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine($"The year {year} is a Leap year");
            }
            else
            {
                Console.WriteLine($"The year {year} is NOT a Leap year");

            }
        }
    }
}
