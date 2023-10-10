using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level7
{
    public static class Dominion
    {
        public static void Calculations()
        {
            Console.WriteLine("How many  provinces?");
            int provinces = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many duchies?");
            int duchies = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many estates?");
            int estates = Convert.ToInt32(Console.ReadLine());

            int total = provinces * 1 + duchies * 3 + estates * 6;

            Console.WriteLine("Your point total: " + total);
        }
    }
}
