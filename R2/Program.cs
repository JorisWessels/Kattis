using System;

namespace R2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(RestoreBirthdayPresent(Console.ReadLine()));
        }

        public static int RestoreBirthdayPresent(string input)
        {
            var intStrings = input.Split(' ');
            return Convert.ToInt32(intStrings[1]) * 2 - Convert.ToInt32(intStrings[0]);
        }
    }
}