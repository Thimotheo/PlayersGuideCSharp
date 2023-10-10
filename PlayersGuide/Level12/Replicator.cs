using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level12
{
    public class Replicator
    {
        public void Launch()
        {
            int[] firstInput = new int[5];
            Console.WriteLine("What are your inputs for the array?");
            firstInput[0] = Convert.ToInt32(Console.ReadLine());
            firstInput[1] = Convert.ToInt32(Console.ReadLine());
            firstInput[2] = Convert.ToInt32(Console.ReadLine());
            firstInput[3] = Convert.ToInt32(Console.ReadLine());
            firstInput[4] = Convert.ToInt32(Console.ReadLine());

            int[] copiedInput = new int[5];
            for (int i = 0; i < firstInput.Length; i++)
            {
                firstInput[i] = copiedInput[i];
            }

            Console.WriteLine("The original input is: ");
            for (int i = 0; i < firstInput.Length; i++)
            {
                Console.WriteLine(firstInput[i]);
            }

            Console.WriteLine("The copied input is: ");
            for (int i = 0; i < copiedInput.Length; i++)
            {
                Console.WriteLine(copiedInput[i]);
            }
        }
    }
}
