using System;

namespace TicTacToe_Kata
{
    public class Player
    {
        public Boolean isBot { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }//-1 is x, 1 is o

        public Player(string name, bool isBot)
        {
            this.Name = name;
            this.isBot = isBot;
        }

        public bool CompareTo(Player otherPlayer)
        {
            return this.Type == otherPlayer.Type;
        }
    }
}