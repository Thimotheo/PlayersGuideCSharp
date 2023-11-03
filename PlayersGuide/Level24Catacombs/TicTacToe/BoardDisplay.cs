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
            symbols[0, 0] = GetCharacterFor(board.GetContentsOfCell(0, 0));
            symbols[0, 1] = GetCharacterFor(board.GetContentsOfCell(0, 1));
            symbols[0, 2] = GetCharacterFor(board.GetContentsOfCell(0, 2));
            symbols[1, 0] = GetCharacterFor(board.GetContentsOfCell(1, 0));
            symbols[1, 1] = GetCharacterFor(board.GetContentsOfCell(1, 1));
            symbols[1, 2] = GetCharacterFor(board.GetContentsOfCell(1, 2));
            symbols[2, 0] = GetCharacterFor(board.GetContentsOfCell(2, 0));
            symbols[2, 1] = GetCharacterFor(board.GetContentsOfCell(2, 1));
            symbols[2, 2] = GetCharacterFor(board.GetContentsOfCell(2, 2));

            Console.WriteLine($"{symbols[0, 0]} | {symbols[0, 1]} | {symbols[0, 2]}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{symbols[1, 0]} | {symbols[1, 1]} | {symbols[1, 2]}");
            Console.WriteLine("----------------------------------");
            Console.WriteLine($"{symbols[2, 0]} | {symbols[2, 1]}, {symbols[2, 2]}");

        }



        private char GetCharacterFor(Cell cell)
            => cell switch { Cell.X => 'X', Cell.O => 'O', Cell.Empty => ' ' };

    }
}
