using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level11
{
    public static class MagicCannon
    {
        public static void DetermineCanonball()
        {
            for (int number = 0; number < 100; number++)
            {
                if (number % 5 == 0 && number % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{number}: Electric and Fire");
                }
                else if (number % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"{number}: Electric");
                }
                else if (number % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{number}: Fire");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Console.WriteLine($"{number}: Normal");
                }
            }
        }
    }
}
