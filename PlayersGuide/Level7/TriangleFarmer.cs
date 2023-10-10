using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level7
{
    public static class TriangleFarmer
    {
        public static float Calculations()
        {
            Console.WriteLine("What is the base size?");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the height?");
            int height = Convert.ToInt32(Console.ReadLine());
            float area = (size * height) / 2;
            Console.WriteLine(area);
            return area;
        }
    }
}
