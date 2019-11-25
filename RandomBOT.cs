using System;

namespace TicTacToe_Kata
{
    public class RandomBOT : Player
    {
        
        public RandomBOT(string name, bool isBot) : base(name, isBot)
        {
            this.isBot = isBot;
            this.Name = name;
        }


    }
}