namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Flip coin problem");
            Console.WriteLine("Enter 2 for check Leap year");
            Console.WriteLine("Enter 3 for find power of Two");
            Console.WriteLine("Enter 4 for find Harmonic Number");
            Console.WriteLine("Enter 5 for find Prime Factor of a number");
            Console.WriteLine("Enter 6 for Compute Quotient and Remainder");
            Console.WriteLine("Enter 7 for find number is even or odd");
            Console.WriteLine("Enter 8 for Swap two number");
            Console.WriteLine("Enter 9 for check an Alphabet is Vowel or Consonant");


            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            switch (choice)
            {
                case 1:
                    Q1_Flip_Coin flip_Coin = new Q1_Flip_Coin();
                    flip_Coin.Flip();
                    break;
                case 2:
                    Leap_Year leap_Year= new Leap_Year();
                    leap_Year.Check_Leap_Year();
                    break;
                case 3:
                    PowerOfTwo powerOfTwo = new PowerOfTwo();
                    powerOfTwo.GetPowerOfTwo();
                    break;
                case 4:
                    HarmonicNumber harmonicNumber = new HarmonicNumber();
                    harmonicNumber.GetHarmonicNumber();
                    break;
                case 5:
                    PrimeFactor primeFactor = new PrimeFactor();
                    primeFactor.GetPrimeFactor();
                    break;
                case 6:
                    ComputeQuotientAndRemainder computeQuotientAndRemainder = new ComputeQuotientAndRemainder();
                    computeQuotientAndRemainder.GetQuotientAndRemainder();
                    break;
                case 7:
                    EvenOrOdd evenOrOdd = new EvenOrOdd();
                    evenOrOdd.GetEvenOrOdd();
                    break;
                case 8:
                    SwapTwoNumbers swapTwoNumbers = new SwapTwoNumbers();
                    swapTwoNumbers.SwapTwoNo();
                    break;
                case 9:
                    VowelOrConsonant vowelOrConsonant = new VowelOrConsonant();
                    vowelOrConsonant.GetVowelOrConsonant();
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }
    }
}