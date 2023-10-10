using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extensions
{
    public static class TakingANumber
    {
        public static int AskForNumber(string text)
        {
            Console.WriteLine(text);
            int userInput = Convert.ToInt32(Console.ReadLine());
            return userInput;
        }

        public static int AskForNumberInRange(string text, int min, int max)
        {
            while (true)
            {
                int number = AskForNumber(text);
                if (number <= min && number >= max)
                {
                    return number;
                }
            }
        }
    }
}
