using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level12
{
    public class LawsofFreach
    {
        public void ForeachSmallest()
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int currentSmallest = int.MaxValue;
            foreach (int index in array)
            {
                if (array[index] < currentSmallest)
                    currentSmallest = array[index];
            }
            Console.WriteLine(currentSmallest);
        }

        public void ForeachAverage()
        {
            int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };
            int total = 0;
            foreach (int index in array)
                total += array[index];
            float average = (float)total / array.Length;
            Console.WriteLine(average);
        }

    }
}
