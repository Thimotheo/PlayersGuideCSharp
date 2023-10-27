using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level24Catacombs
{
    public class Point
    {
        public float XCoordinate { get; }
        public float YCoordinate { get; }


        public Point(float x, float y)
        {
            XCoordinate = x;
            YCoordinate = y;
        }

        public Point() : this(0, 0)
        {

        }

        //The properties in my code are immutable.
        //There is no reason to make them mutable, since our program does not require the user to provide coordinates, nor do other classes require setter access.
    }
}
