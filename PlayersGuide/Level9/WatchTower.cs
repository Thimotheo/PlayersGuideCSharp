using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level9
{
    public static class WatchTower
    {
        public static void Location()
        {
            Console.WriteLine("What is x?");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is y?");
            int y = Convert.ToInt32(Console.ReadLine());

            if (y > 0)
            {
                if (x < 0)
                {
                    Console.WriteLine("The enemy is to the northwest!");
                }
                else if (x > 0)
                {
                    Console.WriteLine("The enemy is to the northeast!");
                }
                else { Console.WriteLine("The enemy is to the north!"); }

            }
            if (y == 0)
            {
                if (x == 0)
                {
                    Console.WriteLine("The enemy is here!");
                }
                else if (x > 0)
                {
                    Console.WriteLine("The enemy is to the east!");
                }
                else
                {
                    Console.WriteLine("The enemy is to the west!");
                }
            }
            if (y < 0)
            {
                if (x < 0)
                {
                    Console.WriteLine("The enemy is to the southwest!");
                }
                else if (x > 0)
                {
                    Console.WriteLine("The enemy is to the southeast!");
                }
                else
                {
                    Console.WriteLine("The enemy is to the south!");
                }
            }
        }
    }
}
