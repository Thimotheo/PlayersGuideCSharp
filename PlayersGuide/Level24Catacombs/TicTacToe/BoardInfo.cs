using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Level24Catacombs.TicTacToe.CellStates;

namespace Level24Catacombs.TicTacToe
{
    public class BoardInfo
    {
        private readonly Cell[,] _cells = new Cell[3, 3];

        public Cell GetContentsOfCell(int row, int column)
            => _cells[row, column];
        public void FillCell(int row, int column, Cell value)
            => _cells[row, column] = value;
        public bool CellIsEmpty(int row, int column)
           => _cells[row, column] == Cell.Empty;
    }
}
