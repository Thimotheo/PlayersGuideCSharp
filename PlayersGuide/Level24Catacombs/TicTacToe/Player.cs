using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Level24Catacombs.TicTacToe.CellStates;

namespace Level24Catacombs.TicTacToe
{
    public class Player
    {
        public Cell Symbol { get; }
        public Player(Cell symbol)
        {
            Symbol = symbol;
        }

        public Square PickSquare(BoardInfo board)
        {
            while (true)
            {
                Console.WriteLine("What square do you want to place in?");
                ConsoleKey key = Console.ReadKey().Key;
                Console.WriteLine();

                Square choice = key switch
                {
                    ConsoleKey.NumPad1 => new Square(2, 0),
                    ConsoleKey.NumPad2 => new Square(2, 1),
                    ConsoleKey.NumPad3 => new Square(2, 2),
                    ConsoleKey.NumPad4 => new Square(1, 0),
                    ConsoleKey.NumPad5 => new Square(1, 1),
                    ConsoleKey.NumPad6 => new Square(1, 2),
                    ConsoleKey.NumPad7 => new Square(0, 0),
                    ConsoleKey.NumPad8 => new Square(0, 1),
                    ConsoleKey.NumPad9 => new Square(0, 2),

                };
                if (board.CellIsEmpty(choice.Row, choice.Column))
                    return choice;
                else
                    Console.WriteLine("This square is already taken.");
            }
        }
    }
}
