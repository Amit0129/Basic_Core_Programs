using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class Q1_Flip_Coin
    {
        public void Flip(int no_Of_Time)
        { 
            Random random = new Random();
            int heads = 0, tails = 0;
            for (int i = 0; i < no_Of_Time; i++)
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
            
            Console.WriteLine("Percentage of Head = " + ((heads / (float) no_Of_Time))*100);
            Console.WriteLine("Percentage of Tail = " + ((tails / (float)  no_Of_Time))*100);
        }
    }
}
