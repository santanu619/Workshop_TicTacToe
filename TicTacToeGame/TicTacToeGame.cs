using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    class TicTacToeGame
    {
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
            
                Console.WriteLine("Choose Token Representation for a Player: X or O");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "X":
                        Console.WriteLine("Player 1 choose X! So its Player 1 turn and ByDefault, Computer assigned as 'O' ");
                        return 'X';

                    case "O":
                        Console.WriteLine("Player 1 choose 0! So Computer assigned as 'O' and it's computer turn ");
                        return 'O';

                    default:
                        Console.WriteLine("Choose a valid choice to begin the game");
                        break;
                }
                return 'X';
            

        }
    }
}

