using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
 
            string userChoiceString;
            Random rand = new Random();
            do
            {
                Console.WriteLine("What dice are you wanting roll?:");
                Console.WriteLine("D4");
                Console.WriteLine("D6");
                Console.WriteLine("D8");
                Console.WriteLine("D10");
                Console.WriteLine("D12");
                Console.WriteLine("D20");
                Console.WriteLine("D100");
                Console.WriteLine("Roll Stats");
                Console.WriteLine("Exit");
                Console.WriteLine();
                Console.Write("Menu Option: ");

                
                userChoiceString = Console.ReadLine()?.ToUpper();


                Console.WriteLine();
                if (userChoiceString == "D4" || userChoiceString == "4") { 
                
                    int diceRolls;
                    Console.WriteLine("How many dice would you like to roll?");
                    Console.WriteLine();
                    if (!int.TryParse(Console.ReadLine(), out diceRolls) || diceRolls < 1)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }
                    
                        Console.WriteLine();
                        Console.WriteLine("Rolling...");

                        for (int i = 0; i < diceRolls; i++)
                        {
                            Console.WriteLine(rand.Next(1, 5));
                        }
                        Console.WriteLine();
                    

                }

               else if (userChoiceString == "D6" || userChoiceString ==  "6")
                    {
                    int diceRolls;
                    Console.WriteLine("How many dice would you like to roll?");
                    Console.WriteLine();

                    if (!int.TryParse(Console.ReadLine(), out diceRolls) || diceRolls < 1)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Rolling...");

                    for (int i = 0; i < diceRolls; i++)
                    {
                        Console.WriteLine(rand.Next(1, 7));
                    }
                    Console.WriteLine();
                }

                else if (userChoiceString == "8" || userChoiceString == "D8")
                {
                    int diceRolls;
                    Console.WriteLine("How many dice would you like to roll?");
                    Console.WriteLine();

                    if (!int.TryParse(Console.ReadLine(), out diceRolls) || diceRolls < 1)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Rolling...");

                    for (int i = 0; i < diceRolls; i++)
                    {
                        Console.WriteLine(rand.Next(1, 9));
                    }
                    Console.WriteLine();

                }

                else if (userChoiceString == "D10" || userChoiceString == "10")
                {
                    int diceRolls;
                    Console.WriteLine("How many dice would you like to roll?");
                    Console.WriteLine();
                    if (!int.TryParse(Console.ReadLine(), out diceRolls) || diceRolls < 1)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }

                    Console.WriteLine();
                    Console.WriteLine("Rolling...");

                    for (int i = 0; i < diceRolls; i++)
                    {
                        Console.WriteLine(rand.Next(1, 11));
                    }
                    Console.WriteLine();

                }

                else if (userChoiceString == "D12" || userChoiceString == "12")
                {
                    int diceRolls;
                    Console.WriteLine("How many dice would you like to roll?");
                    Console.WriteLine();

                    if (!int.TryParse(Console.ReadLine(), out diceRolls) || diceRolls < 1)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Rolling...");


                    for (int i = 0; i < diceRolls; i++)
                    {
                        Console.WriteLine(rand.Next(1, 13));
                    }

                    Console.WriteLine();
                }

                else if (userChoiceString == "D20" || userChoiceString == "20")
                {
                    int diceRolls;
                    Console.WriteLine("How many dice would you like to roll?");
                    Console.WriteLine();

                    if (!int.TryParse(Console.ReadLine(), out diceRolls) || diceRolls < 1)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Rolling...");

                    for (int i = 0; i < diceRolls; i++)
                    {
                        Console.WriteLine(rand.Next(1, 21));
                    }
                    Console.WriteLine();
                }

                else if (userChoiceString == "D100" || userChoiceString == "100")
                {
                    int diceRolls;
                    Console.WriteLine("How many dice would you like to roll?");
                    Console.WriteLine();

                    if (!int.TryParse(Console.ReadLine(), out diceRolls) || diceRolls < 1)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                        Console.WriteLine();
                        continue;
                    }
                    Console.WriteLine();
                    Console.WriteLine("Rolling...");


                    for (int i = 0; i < diceRolls; i++)
                    {
                        Console.WriteLine(rand.Next(1, 101));
                    }
                    Console.WriteLine();
                }

                else if (userChoiceString == "ROLL" || userChoiceString == "STATS" || userChoiceString == "ROLL STATS" || userChoiceString == "ROLLSTATS")
                {
                    Console.WriteLine("Rolling...");
                    int[] rolls = new int[4];

                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            rolls[j] = rand.Next(1, 7);
                        }

                        Array.Sort(rolls);
                        Console.WriteLine(rolls[1] + rolls[2] + rolls[3]);
                        Console.WriteLine();
                    }
                }

                else if (userChoiceString != "EXIT")
                {
                    Console.WriteLine("Invalid answer, please type the number or name");
                    Console.WriteLine();
                }

            } while (userChoiceString != "EXIT");
            Console.WriteLine("Thank you :)");
            Console.ReadLine();

        }
    }
}
