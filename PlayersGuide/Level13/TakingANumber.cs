using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level13
{
    public class TakingANumber
    {
        public int AskForANumber(string text)
        {
            Console.WriteLine(text);
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }

        public int AskForANumberInRange(string text, int min, int max)
        {

            while (true)
            {
                int number = AskForANumber(text);
                if (number <= min && number >= max)
                {
                    return number;
                }
            }
        }
    }
}
