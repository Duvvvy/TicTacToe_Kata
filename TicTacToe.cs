using System;
using System.Collections.Generic;

namespace TicTacToe_Kata
{
    public class TicTacToe
    {
        
        private Player CurrentPlayer { get; set; }
        private int GameType { get; set; }//Ready for 3d
        private Board Board { get; set; }
        public List<Player> Players = new List<Player>();
        public Controller Controller { get; set; }


        public TicTacToe()
        {
            CreateBoard();
            Controller = new Controller();
            InitialisePlayers(); 
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

        public void StartGame()
        {
            bool stillPlaying = true;
            int currentPlayer = 0;
            while (stillPlaying)
            {
                stillPlaying = PlayTurn(Players[currentPlayer]);

                if (currentPlayer == 0)
                {
                    currentPlayer = 1;
                }
                else if (currentPlayer == 1)
                {
                    currentPlayer = 0;
                }
            }
            
            Console.Out.WriteLine("Thanks for playing!");
        }

        public bool PlayTurn(Player player)
        {
            DisplayBoard(Board);
            Console.Out.WriteLine("Please make your move " + player.Name);
            CurrentPlayer = player;

            //TODO add error message for player overwriting board
            bool validMove = false;
            while (!validMove)
            {
                validMove = ValidateMove(Board, Controller.GetMove(player));
            }
            
            
            if (IsWinner(Board, player))
            {
                return false;
            }
                    
            if (Board.TurnsInCurrentRound >= Board.Size * Board.Size)
            {//TODO turn into function
                Console.Out.WriteLine("The board is full");
                return false;
            }

            return true;
        }
        
        private void CreateBoard()
        {
            Board = new Board();
            Board.Create(3,1);
        }

        

        public void DisplayBoard(Board board)
        {
            board.DisplayBoard();
        }

        public bool ValidateMove(Board board, Move move)
        {
            if (move.X <= board.Size && move.Y <= board.Size)//TODO check bounds
            {
                if (board.GameBoard[move.X,move.Y] != -1 && board.GameBoard[move.X,move.Y] != 1)
                {//Problem, these can be null and therefore will throw an exception
                    //add bounds
                    board.ImplementMove(move);
                    return true;
                }
            }
            
            return false;
        }//Dont modify move

        

        public bool IsWinner(Board board, Player player)
        {//TODO Clean this up, DRY
                        int check = 0;
            //Check horizontals
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    check -=- board.GameBoard[i,j];
                }

                if (check == board.Size)
                {//TODO add interface to differentiate between game/round for advanced
                    //This means that three crosses were found in a row
                    //Crosses are a positive 1, so when you add a row of the board, and the outcome is equal to the board size this must be a win condition.
                    Console.Out.WriteLine("Crosses have won the game!");
                    return true;
                }

                if (check == -board.Size)
                {
                    //This means that three crosses were found in a row
                    //Crosses are a positive 1, so when you add a row of the board, and the outcome is equal to the board size this must be a win condition.
                    Console.Out.WriteLine("Noughts have won the game!");
                    return true;
                }

                check = 0;
                
            }
            
            //Check vertical
            for (int i = 0; i < board.Size; i++)
            {
                for (int j = 0; j < board.Size; j++)
                {
                    check -=-  board.GameBoard[j,i];
                }

                if (check == board.Size)
                {//TODO add interface to differentiate between game/round for advanced
                    //This means that three crosses were found in a row
                    //Crosses are a positive 1, so when you add a row of the board, and the outcome is equal to the board size this must be a win condition.
                    Console.Out.WriteLine("Crosses have won the game!");
                    return true;
                }

                if (check == -board.Size)
                {
                    //This means that three crosses were found in a row
                    //Crosses are a positive 1, so when you add a row of the board, and the outcome is equal to the board size this must be a win condition.
                    Console.Out.WriteLine("Noughts have won the game!");
                    return true;
                }

                check = 0;
                
            }
            
            for (int row = 0; row < board.Size; row++)
            {
                check -=- board.GameBoard[row,row];
            }

            if (check == board.Size)
            {
                Console.Out.WriteLine("Crosses have won the game!");
                return true;
            }
            
            if (check == -board.Size)
            {
                Console.Out.WriteLine("Noughts have won the game!");
                return true;
            }
            
            for (int row = board.Size; row < 0; row--)
            {
                check -=- board.GameBoard[row,row];
            }

            if (check == board.Size)
            {
                Console.Out.WriteLine("Crosses have won the game!");
                return true;
            }
            
            if (check == -board.Size)
            {
                Console.Out.WriteLine("Noughts have won the game!");
                return true;
            }
            
            
            return false;
        }

        public bool IsDraw(Board board)
        {
            if (board.TurnsInCurrentRound == (board.Size * board.Size))
            {
                return true;
            }

            return false;
        }
    }
}