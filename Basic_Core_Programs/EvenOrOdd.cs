using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class EvenOrOdd
    {
        public void GetEvenOrOdd() 
        {
            Console.WriteLine("Emter a Number");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"The number {num} is Even number");
            }
            else
            {
                Console.WriteLine($"The number {num} is Odd number");
            }
        }
    }
}
