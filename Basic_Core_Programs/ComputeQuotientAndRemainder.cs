using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class ComputeQuotientAndRemainder
    {
        public void GetQuotientAndRemainder()
        {
            Console.WriteLine("Enter dividend");
            int dividend = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter divisor");
            int divisor = Convert.ToInt32(Console.ReadLine());

            int quot = dividend / divisor;
            int rem = dividend % divisor;

            Console.WriteLine("Dividend:{0} Divisor:{1}", dividend, divisor);
            Console.WriteLine("Quotient = " + quot);
            Console.WriteLine("Remainder = " + rem);
        }
    }
}
