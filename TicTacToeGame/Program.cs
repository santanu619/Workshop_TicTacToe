using System;

namespace TicTacToeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] board = new char[10];
            TicTacToeGame game = new TicTacToeGame();
            game.GameBoard();
            game.Choice();
            game.showBoard(board);
            game.selectPosition(board);
        }
    }
}
