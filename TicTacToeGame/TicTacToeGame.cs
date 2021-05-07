using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class TicTacToeGame
    {
        char[] board = new char[10];
        public void GameBoard()
        {
            char[] board = new char[10];
            for(int i=1;i<10;i++)
            {
                board[i] = ' ';
            }
           
        }

        public char Choice()
        {
            {
                Console.WriteLine("Choose a player to start: X or O");
                string userChoice = Console.ReadLine();
                if (userChoice == "X")
                    return 'X';
                if (userChoice == "O") 
                    return 'O';
                return 'X';
            }
        }

        public void showBoard()
        {

            Console.WriteLine("| " + board[1] + " | " + board[2] + " | " + board[3] + " |");
            Console.WriteLine("----------");
            Console.WriteLine("| " + board[4] + " | " + board[5] + " | " + board[6] + " |");
            Console.WriteLine("----------");
            Console.WriteLine("| " + board[7] + " | " + board[8] + " | " + board[9] + " |");
            Console.WriteLine("----------");

        }
    }
}

