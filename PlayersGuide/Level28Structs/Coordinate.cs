using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level28Structs
{
    public struct Coordinate
    {
        public int Row { get; }
        public int Column { get; }
        public Coordinate(int row, int column) { Row = row; Column = column; }

        public static bool CheckIfAdjacent(Coordinate a, Coordinate b)
        {
            int rowDifference = a.Row - b.Row;
            int columnDifference = a.Column - b.Column;

            if (Math.Abs(rowDifference) <= 1 && columnDifference == 0)
                return true;

            if (Math.Abs(columnDifference) <= 1 && rowDifference == 0)
                return true;

            return false;
        }
    }
}
