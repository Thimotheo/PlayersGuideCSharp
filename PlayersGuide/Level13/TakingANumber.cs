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

            Console.WriteLine(text);
            int input = Convert.ToInt32(Console.ReadLine());
            if (input <= min && input >= max)
            {
                return input;
            }
            else return AskForANumberInRange(text, min, max);

        }
    }
}
