namespace TicTacToe_Kata
{
    public class Player
    {
        public string Name { get; set; }
        public int Type { get; set; }//-1 is x, 1 is o

        public Player(string name)
        {
            this.Name = name;
        }

        public bool CompareTo(Player otherPlayer)
        {
            return this.Type == otherPlayer.Type;
        }
    }
}