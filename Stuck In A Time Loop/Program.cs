using System;

namespace Stuck_In_A_Time_Loop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            SayAbracadabra(Convert.ToInt32(Console.ReadLine()));
        }

        public static void SayAbracadabra(int amount)
        {
            for (var i = 0; i < amount; i++) {
                Console.WriteLine($"{i + 1} Abracadabra");
            }
        }
    }
}