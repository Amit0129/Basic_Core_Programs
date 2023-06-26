using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class PowerOfTwo
    {
        public void GetPowerOfTwo()
        {
            bool check = true;
            while (check)
            {
                Console.WriteLine("Enter a number between 01-30");
                int number = Convert.ToInt32(Console.ReadLine());
                if (number<31)
                {
                    for (int i = 1; i <= number; i++)
                    {
                        int powerValue = (int)Math.Pow(2, i);
                        Console.WriteLine($"{i} to the power 2 is {powerValue}");
                    }
                    check = false;
                }
            }
            
        }
    }
}
