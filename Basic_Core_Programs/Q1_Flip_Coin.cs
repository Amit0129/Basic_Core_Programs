using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class Q1_Flip_Coin
    {
        public void Flip()
        {
            Console.WriteLine("Enter the number of time flips");
            int noOfTimes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Random random = new Random();
            int heads = 0, tails = 0;
            for (int i = 0; i < noOfTimes; i++)
            {
                double num = random.NextDouble();
                if (num < 0.5)
                {
                    tails++;
                }
                else
                {
                    heads++;
                }
            }
            
            Console.WriteLine("Percentage of Head = " + ((heads / (float)noOfTimes))*100);
            Console.WriteLine("Percentage of Tail = " + ((tails / (float)noOfTimes))*100);
        }
    }
}
