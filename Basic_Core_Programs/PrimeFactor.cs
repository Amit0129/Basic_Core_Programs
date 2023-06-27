using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class PrimeFactor
    {
        public bool CheckPrime(int givenNo)
        {
            int result=0;
            if (givenNo < 2)
            {
                return false;
            }
            else if (givenNo == 2)
            {
                return true;

            }
            else
            {
                for (int i = 1; i <= givenNo; i++)
                {
                    if (givenNo % i == 0)
                    {
                        result++;
                    }
                }
                if (result == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public void GetPrimeFactor()
        {
            Console.WriteLine("Enter a number to find it prime factor");
            int number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0 && CheckPrime(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
