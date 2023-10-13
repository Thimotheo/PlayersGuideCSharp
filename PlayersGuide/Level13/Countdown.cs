using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level13
{
    public class Countdown
    {

        public static void ToZero(int number)
        {

            if (number == 0) { return; }

            Console.WriteLine(number);
            ToZero(number - 1);
        }
    }
}
