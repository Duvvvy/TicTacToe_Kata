using System;

namespace TicTacToe_Kata
{
    public class Board
    {
        //Board needs to store amount of turns
        
        /*
         * Stores data about pieces, size of board and dimensions (3d etc)
         */
        public int Size { get; private set; }
        private int Dimensions { get; set; }
        public int[,] GameBoard { get; set; }
        public int TurnsInCurrentRound { get; set; }
        //TODO iterate this variable on turn end



        public Board()
        {
            
        }
        
        public void ImplementMove(Move move)
        {
            TurnsInCurrentRound++;
            GameBoard[move.X, move.Y] = move.Type;
        }
        
        public void Create(int size, int dimensions)
        {
            Size = size;
            Dimensions = dimensions;
            GameBoard = new int[size,size];
        }

        public void DisplayBoard()
        {
            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    switch (GameBoard[i, j])
                    {
                        case -1:
                            Console.Out.Write("  [X]  ");
                            break;
                        case 1:
                            Console.Out.Write("  [O]  ");
                            break;
                        case 0:
                            Console.Out.Write(" [{0},{1}] ",i,j);
                            break;
                    }
                }
                Console.Out.WriteLine("");
            }
        }
    }
}