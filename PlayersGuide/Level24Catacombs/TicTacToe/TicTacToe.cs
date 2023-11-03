using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Level24Catacombs.TicTacToe.CellStates;

namespace Level24Catacombs.TicTacToe
{
    public class TicTacToe
    {
        public void Run()
        {
            BoardDisplay display = new BoardDisplay();
            Player player1 = new Player(Cell.X);
            Player player2 = new Player(Cell.O);
            BoardInfo board = new BoardInfo();

            int turnNumber = 0;

            Player currentPlayer = player1;

            while (turnNumber < 9)
            {
                display.Draw(board);
                Console.WriteLine($"Turn {turnNumber}.");
                Console.WriteLine($"It is {currentPlayer.Symbol}'s turn.");

                Square choice = currentPlayer.PickSquare(board);
                board.FillCell(choice.Row, choice.Column, currentPlayer.Symbol);

                if (IsWinner(board, Cell.X))
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    display.Draw(board);
                    Console.WriteLine("X has won!");

                    GameOver();
                }
                else if (IsWinner(board, Cell.O))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    display.Draw(board);
                    Console.WriteLine("O has won!");
                    GameOver();
                }

                currentPlayer = currentPlayer == player1 ? player2 : player1;
                //if currentPlayer == player1, next player == player2
                //if currentPlayer == player2, next player == player1, etc etc

                turnNumber++;
            }
            display.Draw(board);
            Console.WriteLine("It's a draw!!");
            GameOver();
        }

        private bool IsWinner(BoardInfo board, Cell playerInput)
        {
            //rows
            if (board.GetContentsOfCell(0, 0) == playerInput && board.GetContentsOfCell(0, 1) == playerInput && board.GetContentsOfCell(0, 2) == playerInput)
                return true;
            if (board.GetContentsOfCell(1, 0) == playerInput && board.GetContentsOfCell(1, 1) == playerInput && board.GetContentsOfCell(1, 2) == playerInput)
                return true;
            if (board.GetContentsOfCell(2, 0) == playerInput && board.GetContentsOfCell(2, 1) == playerInput && board.GetContentsOfCell(2, 2) == playerInput)
                return true;

            //columns
            if (board.GetContentsOfCell(0, 0) == playerInput && board.GetContentsOfCell(1, 0) == playerInput && board.GetContentsOfCell(2, 0) == playerInput)
                return true;
            if (board.GetContentsOfCell(0, 1) == playerInput && board.GetContentsOfCell(1, 1) == playerInput && board.GetContentsOfCell(1, 2) == playerInput)
                return true;
            if (board.GetContentsOfCell(0, 2) == playerInput && board.GetContentsOfCell(1, 2) == playerInput && board.GetContentsOfCell(2, 2) == playerInput)
                return true;

            //diagonals
            if (board.GetContentsOfCell(0, 0) == playerInput && board.GetContentsOfCell(1, 1) == playerInput && board.GetContentsOfCell(2, 2) == playerInput)
                return true;
            if (board.GetContentsOfCell(2, 0) == playerInput && board.GetContentsOfCell(1, 1) == playerInput && board.GetContentsOfCell(0, 2) == playerInput)
                return true;

            return false;
        }

        private void GameOver()
        {
            Console.WriteLine("The game is over. Press any button to exit.");
            Console.ReadKey();

            Environment.Exit(0);
        }

        //if we needed multiple rounds, I'd write a method at the start to determine how many rounds you want
        //and one to keep score between individual games
    }
}
