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

        public int X { get; set; }
        public int Y { get; set; }
        
        public int Type { get; set; }

        public Move(int x, int y, int type)
        {
            this.Y = y;
            this.X = x;
            Type = type;
        }
    }
}