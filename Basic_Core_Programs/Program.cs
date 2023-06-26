namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Flip coin problem");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the number of time flips");
                    int noOfTimes = Convert.ToInt32(Console.ReadLine());
                    Q1_Flip_Coin flip_Coin = new Q1_Flip_Coin();
                    flip_Coin.Flip(noOfTimes);
                    break;
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }
    }
}