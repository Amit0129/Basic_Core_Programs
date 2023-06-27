using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Core_Programs
{
    public class VowelOrConsonant
    {
        public void GetVowelOrConsonant()
        {
            Console.WriteLine("Enter a Charector [A-Z] [a-z]");
            char alphabet = Convert.ToChar((Console.ReadLine().ToLower()));
            switch (alphabet)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                
                default:
                    Console.WriteLine("The Alphabet is not a vowel");
                    break;
            }
        }
    }
}
