using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.AccessControl;

namespace TicTacToe_Kata
{
    public class CLI
    {
        

        public CLI()
        {
            
        }
        

        public void DecideNoughtsOrCrosses(Player player)
        {
            bool validInput = false;
            while (!validInput)
            {
                Console.Out.WriteLine("Please enter either an \'x\' or and \'o\'");
                var userInput = Console.ReadLine();
                if (userInput == "x")
                {
                    Console.Out.WriteLine("You have chosen crosses");
                    player.Type = -1;
                    validInput = true;
                }

                if (userInput == "o")
                {
                    Console.Out.WriteLine("You have chosen noughts");
                    player.Type = 1;
                    validInput = true;
                }
            }
        }
        
        public Move GetMove(Player player)
        {//Make sure input is bigger than 0
            Console.Out.WriteLine("Where do you want to play?");
            Console.Out.WriteLine("Enter two numbers separately, [x][y] coordinates");

            Console.Out.WriteLine("x coord:");
            int x = Convert.ToInt32(Console.ReadLine());

            Console.Out.WriteLine("y coord");
            int y = Convert.ToInt32(Console.ReadLine());
            
            List<int> list = new List<int>();
            list.Add(x);
            list.Add(y);
            
            return new Move(x, y, player.Type);
        }
        


    }
}