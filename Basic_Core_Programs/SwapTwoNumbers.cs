using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class SwapTwoNumbers
    {
        public void SwapTwoNo() 
        {
            Console.WriteLine("Enter number one");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number two");
            int numberTwo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Befour swaping");
            Console.WriteLine($"Number One is {numberOne}");
            Console.WriteLine($"Number Two is {numberTwo}");
            int temp = numberTwo;
            numberTwo= numberOne;
            numberOne= temp;
            Console.WriteLine("After swaping");
            Console.WriteLine($"Number One is {numberOne}");
            Console.WriteLine($"Number Two is {numberTwo}");
        }
    }
}
