using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level10
{
    public static class BuyingInventory
    {
        public static void DeterminePrice()
        {
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("Rope costs 10 gold");
                    break;
                case 2:
                    Console.WriteLine("Torches cost 15 gold");
                    break;
                case 3:
                    Console.WriteLine("Climbing equipment costs 25 gold");
                    break;
                case 4:
                    Console.WriteLine("Clean water costs 1 gold");
                    break;
                case 5:
                    Console.WriteLine("A machete costs 20 gold");
                    break;
                case 6:
                    Console.WriteLine("A canoe costs 200 gold");
                    break;
                case 7:
                    Console.WriteLine("Food supplies cost 1 gold");
                    break;

            }
        }
    }
}
