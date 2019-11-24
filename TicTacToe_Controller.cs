using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.AccessControl;

namespace TicTacToe_Kata
{
    public abstract class TicTacToe_Controller
    {
        /*
         *    Intent for this class:
         *     Play tic tac toe
         *     Controller (MVC)
         *
         * 
         */

        public abstract Game NewGame();

        public abstract Move GetMove(Player player);

        public abstract void DisplayBoard(Board board);

        public abstract void ValidateMove(Board board, Move move);//Dont modify move

        public abstract void ImplementMove(Board board, Move move);

        public abstract bool IsWinner(Board board, Player player);

        public abstract bool IsDraw(Board board);


        /*
         
         
        private Player CurrentPlayer { get; set; }
        private int GameType { get; set; }//Ready for 3d
        private Board Board { get; set; }
        public List<Player> Players = new List<Player>();

        public Controller Controller { get; set; }
        
        private int TurnsInCurrentRound { get; set; }


        public TicTacToe()
        {
            

        }

        public void StartGame(bool DevLog)
        {
            if (DevLog)
            {
                Console.Out.WriteLine("Current bugs:" +
                                      "Cant exit the game on win condition until after player two has played." +

                                      "");
            }
            
            RefreshBoard();
            Controller = new Controller();
            InitialisePlayers(); 
            
            bool stillPlaying = true;
            while (stillPlaying)
            {
                foreach (Player player in Players)
                {
                    stillPlaying = StartTurn(player);
                }
            }

            //stillPlaying = !HasWon();//is inversed, as the game keeps going until someone wins.

            Console.Out.WriteLine("Thanks for playing!");
            //Console.Out.WriteLine("Would you like to play again?");
            

        }

        private void RefreshBoard()
        {
            Board = new Board();
            Board.Create(3,1);
        }

        private void InitialisePlayers()
        {
            
            Player playerOne = new Player("Player one");
            Player playerTwo = new Player("Player two");

            Players.Add(playerOne);
            Players.Add(playerTwo);
            //TODO change players array to list

            foreach (var player in Players)
            {
                Controller.DecideNoughtsOrCrosses(player);
            }

            if (playerOne.CompareTo(playerTwo))
            {
                Console.Out.WriteLine("Sorry you have both chosen the same piece, player one will now decide");
                Controller.DecideNoughtsOrCrosses(playerOne);
                
                if (playerOne.CompareTo(playerTwo))
                {
                    if (playerOne.Type == 'x')
                    {
                        playerTwo.Type = 'o';
                    }

                    if (playerOne.Type == 'o')
                    {
                        playerTwo.Type = 'x';
                    }
                }
                Console.Out.WriteLine("Thank you for your understanding and cooperation :)");
            }
        }

        private bool HasWon()
        {
            int check = 0;
            //Check horizontals
            for (int i = 0; i < Board.Size; i++)
            {
                for (int j = 0; j < Board.Size; j++)
                {
                    check -=- Board.GameBoard[i,j];
                }

                if (check == Board.Size)
                {//TODO add interface to differentiate between game/round for advanced
                    //This means that three crosses were found in a row
                    //Crosses are a positive 1, so when you add a row of the board, and the outcome is equal to the board size this must be a win condition.
                    Console.Out.WriteLine("Crosses have won the game!");
                    return true;
                }

                if (check == -Board.Size)
                {
                    //This means that three crosses were found in a row
                    //Crosses are a positive 1, so when you add a row of the board, and the outcome is equal to the board size this must be a win condition.
                    Console.Out.WriteLine("Noughts have won the game!");
                    return true;
                }

                check = 0;
                
            }
            
            //Check vertical
            for (int i = 0; i < Board.Size; i++)
            {
                for (int j = 0; j < Board.Size; j++)
                {
                    check -=-  Board.GameBoard[j,i];
                }

                if (check == Board.Size)
                {//TODO add interface to differentiate between game/round for advanced
                    //This means that three crosses were found in a row
                    //Crosses are a positive 1, so when you add a row of the board, and the outcome is equal to the board size this must be a win condition.
                    Console.Out.WriteLine("Crosses have won the game!");
                    return true;
                }

                if (check == -Board.Size)
                {
                    //This means that three crosses were found in a row
                    //Crosses are a positive 1, so when you add a row of the board, and the outcome is equal to the board size this must be a win condition.
                    Console.Out.WriteLine("Noughts have won the game!");
                    return true;
                }

                check = 0;
                
            }
            
            for (int row = 0; row < Board.Size; row++)
            {
                check -=- Board.GameBoard[row,row];
            }

            if (check == Board.Size)
            {
                Console.Out.WriteLine("Crosses have won the game!");
                return true;
            }
            
            if (check == -Board.Size)
            {
                Console.Out.WriteLine("Noughts have won the game!");
                return true;
            }
            
            for (int row = Board.Size; row < 0; row--)
            {
                check -=- Board.GameBoard[row,row];
            }

            if (check == Board.Size)
            {
                Console.Out.WriteLine("Crosses have won the game!");
                return true;
            }
            
            if (check == -Board.Size)
            {
                Console.Out.WriteLine("Noughts have won the game!");
                return true;
            }
            
            
            return false;
        }
        
        
        public bool IsMoveValid(int[] coordinates)
        {
            Console.Out.WriteLine(coordinates[0]);
            Console.Out.WriteLine(coordinates[1]);
            
            
            if (Board.GameBoard[coordinates[0],coordinates[1]] != -1 && Board.GameBoard[coordinates[0],coordinates[1]] != 1)
            {//Problem, these can be null and therefore will throw an exception
                //add bounds
                ModifyBoard(coordinates[0], coordinates[1], CurrentPlayer.Type);
                return true;
            }
            
            
            return false;
        }


        private void ModifyBoard(int x, int y, int type)
        {
            TurnsInCurrentRound++;
            Board.GameBoard[x,y] = type;
        }

        private bool StartTurn(Player player)
        {
            Board.DisplayBoard();
            Console.Out.WriteLine("Please make your move " + player.Name);
            CurrentPlayer = player;

            //TODO add error message for player overwriting board
            bool validMove = false;
            while (!validMove)
            {
                validMove = IsMoveValid(Controller.Move());
            }
            
            
            if (HasWon())
            {
                return false;
            }
                    
            if (TurnsInCurrentRound >= Board.Size * Board.Size)
            {
                Console.Out.WriteLine("The board is full");
                return false;
            }

            return true;
        }

*/
    }

}
