using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class LargestAmongThreeNumbers
    {
        public void GetLargestAmongThreeNumbers() 
        {
            Console.Write("Enter First Number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second Number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Third Number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The first number: " + num1 + " Second number: " + num2 + " Third number: " + num3);


            if (num1 > num2 && num1 > num3)
            {
                Console.WriteLine($"The number {num1} is largest");
            }
            else if (num2 > num1 && num2 > num3)
            {
                Console.WriteLine($"The number {num2} + is largest");
            }
            else
            {
                Console.WriteLine("The number " + num3 + " is largest");
            }
        }
    }
}
