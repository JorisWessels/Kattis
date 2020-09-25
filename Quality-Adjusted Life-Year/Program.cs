using System;

namespace Quality_Adjusted_Life_Year
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CalculateAccumulated(Convert.ToInt32(Console.ReadLine())));
        }

        private static decimal CalculateAccumulated(int periods)
        {
            decimal result = 0;
            for (var i = 0; i < periods; i++) {
                var input = Console.ReadLine();
                if (input != null) {
                    var doubleStrings = input.Split(' ');
                    result += decimal.Parse(doubleStrings[0]) * decimal.Parse(doubleStrings[1]);
                }
            }

            return result;
        }
    }
}