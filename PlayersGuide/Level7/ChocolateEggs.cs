using Level13;
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

            int collected = TakingANumber.AskForANumber("How many eggs have you collected today?");
            int forSister = collected / 4;
            int forDuckbear = collected % 4;

            Console.WriteLine("Each sister gets " + forSister);
            Console.WriteLine("The duckbear gets " + forDuckbear);
        }
    }
}
