using System;

namespace Pot
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Calculate(Convert.ToInt32(Console.ReadLine())));
        }

        public static int Calculate(int numberOfAddends)
        {
            var result = 0;
            for (var i = 0; i < numberOfAddends; i++) {
                var input = Convert.ToInt32(Console.ReadLine());
                result += (int) Math.Pow(input / 10, input % 10);
            }

            return result;
        }
    }
}