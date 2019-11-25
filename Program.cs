using System;

namespace TicTacToe_Kata
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            TicTacToe controller = new TicTacToe();

            Console.Out.WriteLine("Welcome to tic tac toe/ noughts and crosses");
            //Console.Out.WriteLine("How many games would you like to play?");

            //Console.Out.WriteLine("Well, let's try just doing one.");
            controller.StartGame();
            

        }
    }
}