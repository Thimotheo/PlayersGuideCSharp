using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level7
{
    public static class ChocolateEggs
    {
        public static void Calculations()
        {
            Console.WriteLine("How many eggs have you collected today?");
            int collected = Convert.ToInt32(Console.ReadLine());
            int forSister = collected / 4;
            int forDuckbear = collected % 4;

            Console.WriteLine("Each sister gets " + forSister);
            Console.WriteLine("The duckbear gets " + forDuckbear);
        }
    }
}
