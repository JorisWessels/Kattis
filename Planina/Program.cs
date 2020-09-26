using System;

namespace Planina
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(CalcNumberOfPoints(Convert.ToInt32(Console.ReadLine())));
        }

        public static int CalcNumberOfPoints(int numberOfIterations)
        {
            var length = 2;
            var increaseLengthBy = 1;

            for (var i = 0; i < numberOfIterations; i++) {
                length += increaseLengthBy;
                increaseLengthBy += increaseLengthBy;
            }

            return length * length;
        }
    }
}