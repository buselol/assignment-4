using System;

namespace TicTacToe
{
    class Program
    {
        static char[] Board = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static bool Player = true;
        static bool Game = true;

        static void Main()
        {
            Menu();
        }
        
        static void Menu()
        {
            if (Game)
            {
                //Menu Info
                Console.WriteLine("1. New game");
                Console.WriteLine("2. About the author");
                Console.WriteLine("3. Exit");

                Console.Write("= ");

                switch (Console.ReadKey().KeyChar)
                {
                    //Menu Content
                    case '1':
                        Game = false;
                        Start();
                        break;

                    case '2':
                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("Greetings, i am buse iyigün from computer science.");
                        Console.WriteLine("");

                        break;

                    case '3':
                        Console.WriteLine();
                        Console.WriteLine("Do you want to quit? [y/n]");

                        Console.Write("= ");

                        if ($"{Console.ReadKey().KeyChar}".ToLowerInvariant() == "y")
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine();
                        }
                        break;

                    default:
                        Wrong();
                        break;
                }

                Continue();
                Menu();
            }
            else
            {
                Start();
            }
        }

        static void Start()
        {
            Console.Clear();
            DrawBoard();
            DrawPlayer();
            Menu();
        }

        static void Continue()
        {
            Console.Write("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        static void ContinueMenu()
        {
            Console.Write("[Press any key to return to menu...]");
            Console.ReadKey();
            Console.Clear();
        }

        static void Wrong()
        {
            Console.WriteLine();
            Console.WriteLine("False Choice!");
        }

        static void WrongPlay()
        {
            Console.WriteLine();
            Console.WriteLine("False Choice, try again.");
        }

        static void Reset()
        {
            Board[0] = '1';
            Board[1] = '2';
            Board[2] = '3';
            Board[3] = '4';
            Board[4] = '5';
            Board[5] = '6';
            Board[6] = '7';
            Board[7] = '8';
            Board[8] = '9';
            Player = true;
            Game = true;
            ContinueMenu();
        }

        static void DrawBoard()
        {
            Console.WriteLine("Welcome to tictactoe!");
            Console.WriteLine();
            Console.WriteLine($" {Board[0]} | {Board[1]} | {Board[2]} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {Board[3]} | {Board[4]} | {Board[5]} ");
            Console.WriteLine($"---+---+---");
            Console.WriteLine($" {Board[6]} | {Board[7]} | {Board[8]} ");
            Console.WriteLine();
        }

        static void DrawPlayer()
        {
            switch (CheckWin())
            {
                case Result.X:
                    Console.WriteLine("Player 1 Won!");
                    Reset();
                    break;

                case Result.O:
                    Console.WriteLine("Player 2 Won!");
                    Reset();
                    break;

                case Result.Y:
                    Console.WriteLine();
                    Console.WriteLine("game over");
                    Reset();
                    break;

                default:
                    if (Player)
                    {
                        Console.Write("Player 1’s Move= ");
                    }
                    else
                    {
                        Console.Write("Player 2’s Move= ");
                    }

                    char Move = Console.ReadKey().KeyChar;

                    if (Char.IsNumber(Move))
                    {
                        int Number = Convert.ToInt32(Move.ToString());

                        if (Number > 0 && Number < 10)
                        {
                            if (Board[Number - 1] != 'X' && Board[Number - 1] != 'O')
                            {
                                if (Player)
                                {
                                    Board[Number - 1] = 'X';
                                }
                                else
                                {
                                    Board[Number - 1] = 'O';
                                }

                                Player = !Player;
                            }
                            else
                            {
                                WrongPlay();
                                Continue();
                            }
                        }
                        else
                        {
                            WrongPlay();
                            Continue();
                        }
                    }
                    else
                    {
                        WrongPlay();
                        Continue();
                    }
                    break;
            }
        }

        static Result CheckWin()
        {
            if (Board[0] == Board[1] && Board[1] == Board[2])
            {
                if (Board[0] == 'X')
                {
                    return Result.X;
                }
                else
                {
                    return Result.O;
                }
            }
            else if (Board[3] == Board[4] && Board[4] == Board[5])
            {
                if (Board[3] == 'X')
                {
                    return Result.X;
                }
                else
                {
                    return Result.O;
                }
            }
            else if (Board[6] == Board[7] && Board[7] == Board[8])
            {
                if (Board[6] == 'X')
                {
                    return Result.X;
                }
                else
                {
                    return Result.O;
                }
            }
            else if (Board[0] == Board[3] && Board[3] == Board[6])
            {
                if (Board[0] == 'X')
                {
                    return Result.X;
                }
                else
                {
                    return Result.O;
                }
            }
            else if (Board[0] == Board[4] && Board[4] == Board[8])
            {
                if (Board[0] == 'X')
                {
                    return Result.X;
                }
                else
                {
                    return Result.O;
                }
            }
            else if (Board[1] == Board[4] && Board[4] == Board[7])
            {
                if (Board[1] == 'X')
                {
                    return Result.X;
                }
                else
                {
                    return Result.O;
                }
            }
            else if (Board[2] == Board[5] && Board[5] == Board[8])
            {
                if (Board[2] == 'X')
                {
                    return Result.X;
                }
                else
                {
                    return Result.O;
                }
            }
            else if (Board[2] == Board[4] && Board[4] == Board[6])
            {
                if (Board[2] == 'X')
                {
                    return Result.X;
                }
                else
                {
                    return Result.O;
                }
            }

            if (Board[0] != '1' && Board[1] != '2' && Board[2] != '3' && Board[3] != '4' && Board[4] != '5' && Board[5] != '6' && Board[6] != '7' && Board[7] != '8' && Board[8] != '9')
            {
                return Result.Y;
            }

            return Result.Z;
        }

        enum Result
        {
            X,
            O,
            Y,
            Z
        }
    }
}