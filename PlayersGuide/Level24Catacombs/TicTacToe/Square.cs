﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Level24Catacombs.TicTacToe
{
    public class Square
    {
        public int Row { get; }
        public int Column { get; }

        public Square(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }
}
