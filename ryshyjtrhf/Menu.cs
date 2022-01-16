using System;
using System.Collections.Generic;
using System.Text;

namespace ryshyjtrhf
{
  


        {
            internal class Select
            {
                internal static void MenuWrite(char Char)
                {
                    _ = int.TryParse($"{Char}", out int Value);

                    switch ((Menu)Value - 1)
                    {
                        //Menu Content
                        case MenuType.Game:
                            Data.Game = false;
                            Run.Start();
                            break;

                        case MenuType.About:
                            Console.Clear();
                            Console.WriteLine("Greetings, i am buse iyigün from computer science.");
                            Console.WriteLine();
                            break;

                        case MenuType.Exit:
                            Console.WriteLine();
                            Console.WriteLine("Do you want to quit? [y/n]");

                            Console.Write("= ");

                            if ($"{Print.ReadKey().KeyChar}".ToLowerInvariant() == "y")
                            {
                                Environment.Exit(0);
                            }
                            else
                            {
                                Console.WriteLine();
                            }
                            break;

                        default:
                            Run.Wrong();
                            break;
                    }
                }
            }
        }