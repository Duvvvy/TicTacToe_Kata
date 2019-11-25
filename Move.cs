namespace TicTacToe_Kata
{
    public class Move
    {
        /*
         *To store data about players turn
         * Coordinates
         * if it is valid
         * 
         */

        public int X { get; }
        public int Y { get; }
        public int Type { get; }

        public Move(int x, int y, int type)
        {
            this.Y = y;
            this.X = x;
            Type = type;
        }
    }
}