using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Level24Catacombs.TicTacToe.CellStates;

namespace Level24Catacombs.TicTacToe
{
    public class BoardDisplay
    {
        public void Draw(BoardInfo board)
        {
            char[,] symbols = new char[3, 3];

            for (int row = 0; row < 3; row++)
            {
                for (int column = 0; column < 3; column++)
                {
                    symbols[row, column] = GetCharacterFor(board.GetContentsOfCell(row, column));
                }

            }

            Console.WriteLine($"{symbols[0, 0]} | {symbols[0, 1]} | {symbols[0, 2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]}");
            Console.WriteLine("---------");
            Console.WriteLine($"{symbols[2, 0]} | {symbols[2, 1]} | {symbols[2, 2]}");
        }

        private char GetCharacterFor(Cell cell)
            => cell switch { Cell.X => 'X', Cell.O => 'O', Cell.Empty => ' ' };
    }
}
