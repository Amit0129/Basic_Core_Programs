﻿namespace Basic_Core_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1 for Flip coin problem");
            Console.WriteLine("Enter 2 for check Leap year");
            Console.WriteLine("Enter 3 for find power of 2");
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
                default:
                    Console.WriteLine("Enter a valid choice");
                    break;
            }
        }
    }
}