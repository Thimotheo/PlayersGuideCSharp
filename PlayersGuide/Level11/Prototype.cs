using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level11
{
    public static class Prototype
    {
        public static void Testing()
        {
            int input = Convert.ToInt32(Console.ReadLine());

            do
            {
                Console.WriteLine("User 1, give us a number between 0 and 100: ");
            } while (input < 0 || input > 100);

            Console.Clear();

            Console.WriteLine("User 2, guess the number: ");

            while (true)
            {
                Console.WriteLine("What is your next guess?");
                int guess = Convert.ToInt32(Console.ReadLine());

                if (guess > input)
                {
                    Console.WriteLine($"{guess} is too high.");
                }
                else if (guess < input)
                {
                    Console.WriteLine($"{guess} is too low.");
                }
                else break;
            }
            Console.WriteLine("You have guessed the number correctly!");
        }
    }
}
