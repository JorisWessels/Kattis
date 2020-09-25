using System;

namespace Take_Two_Stones
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CheckWinner(Convert.ToInt32(Console.ReadLine())));
        }

        private static string CheckWinner(int input)
        {
            if (input % 2 != 0) {
                return "Alice";
            }

            return "Bob";
        }
    }
}