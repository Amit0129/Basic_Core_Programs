using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class HarmonicNumber
    {
        public void GetHarmonicNumber()
        {
            Console.WriteLine("Enter a number");
            double number = Convert.ToDouble(Console.ReadLine());
            double ans = 0;
            for (int i = 1; i <=number ; i++)
            {
                double temp = 1 / (float)i;
                ans += temp;
            }
            Console.WriteLine($"The Harmonic number of {number} is {ans}");
        }
    }
}
