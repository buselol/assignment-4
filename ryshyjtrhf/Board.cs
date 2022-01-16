using System;
using System.Collections.Generic;
using System.Text;

namespace ryshyjtrhf
{
    internal class Board
    {
       


    
        
        
            internal static readonly char[] board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        internal static bool Player = true;
        internal static bool Game = true;

        internal const ConsoleColor Back = ConsoleColor.Black;
        internal const ConsoleColor Color = ConsoleColor.DarkGreen;
        static void DrawBoard()
        {
            Console.WriteLine("Welcome to tictactoe");
            Console.WriteLine();
            Console.WriteLine($" {0} | {1} | {2}");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {3} | {4} | {5}");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {6} | {7} | {8}");
            Console.WriteLine();
        }

    }

}


