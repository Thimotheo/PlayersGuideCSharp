using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level10
{
    public static class DiscountedInventory
    {
        public static void UpdatedPrices()
        {
            int choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is your name?");
            string? name = Console.ReadLine();
            if (name != "Thijmen")
            {
                switch (choice)
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
            else
            {
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Rope costs 5 gold");
                        break;
                    case 2:
                        Console.WriteLine("Torches cost 7.5 gold");
                        break;
                    case 3:
                        Console.WriteLine("Climbing equipment costs 12.5 gold");
                        break;
                    case 4:
                        Console.WriteLine("Clean water costs 0.5 gold");
                        break;
                    case 5:
                        Console.WriteLine("A machete costs 10 gold");
                        break;
                    case 6:
                        Console.WriteLine("A canoe costs 100 gold");
                        break;
                    case 7:
                        Console.WriteLine("Food supplies cost 0.5 gold");
                        break;

                }
            }
        }
    }
}
