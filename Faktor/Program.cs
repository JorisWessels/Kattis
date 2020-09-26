using System;

namespace Faktor
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CalcImpactFactor(Console.ReadLine()));
        }

        public static int CalcImpactFactor(string numberOfArticles)
        {
            var intStrings = numberOfArticles.Split(' ');
            return (int) (Convert.ToInt32(intStrings[0]) * (Convert.ToInt32(intStrings[1]) - 0.99) + 1);
        }
    }
}