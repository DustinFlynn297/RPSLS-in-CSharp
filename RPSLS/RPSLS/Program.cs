using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playAgain = true;
            String player;
            String computer;
            String answer;
            while (playAgain)
            {
                int scoreCPU = 0;
                int scorePlayer = 0;

                while (scorePlayer < 2 && scoreCPU < 2)
                {
                    player = "";
                    computer = "";
                    answer = "";

                    while (player != "ROCK" && player != "PAPER" && player != "SCISSORS" && player != "LIZARD" && player != "SPOCK")
                    {

                        Console.WriteLine("Enter Rock, Paper, Scissors, Lizard, Spock: ");
                        player = Console.ReadLine();
                        player = player.ToUpper();
                    }


                    switch (random.Next(1, 6))
                    {
                        case 1:
                            computer = "ROCK";
                            break;
                        case 2:
                            computer = "PAPER";
                            break;
                        case 3:
                            computer = "SCISSORS";
                            break;
                        case 4:
                            computer = "LIZARD";
                            break;
                        case 5:
                            computer = "SPOCK";
                            break;
                    }

                    Console.WriteLine("Player: " + player);
                    Console.WriteLine("Computer: " + computer);

                    switch (player)
                    {
                        case "ROCK":
                            if (computer == "ROCK")
                            {
                                Console.WriteLine("It's a draw!");
                            }
                            else if (computer == "PAPER" || computer == "SPOCK")
                            {
                                Console.WriteLine("You lose!");
                                scoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("You win!");
                                scorePlayer++;
                            }
                            break;
                        case "PAPER":
                            if (computer == "PAPER")
                            {
                                Console.WriteLine("It's a draw!");
                            }
                            else if (computer == "SCISSORS" || computer == "LIZARD")
                            {
                                Console.WriteLine("You lose!");
                                scoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("You win!");
                                scorePlayer++;
                            }
                            break;
                        case "SCISSORS":
                            if (computer == "SCISSORS")
                            {
                                Console.WriteLine("It's a draw!");
                            }
                            else if (computer == "ROCK" || computer == "SPOCK")
                            {
                                Console.WriteLine("You lose!");
                                scoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("You win!");
                                scorePlayer++;
                            }
                            break;
                        case "LIZARD":
                            if (computer == "LIZARD")
                            {
                                Console.WriteLine("It's a draw!");
                            }
                            else if (computer == "SCISSORS" || computer == "ROCK")
                            {
                                Console.WriteLine("You lose!");
                                scoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("You win!");
                                scorePlayer++;
                            }
                            break;
                        case "SPOCK":
                            if (computer == "SPOCK")
                            {
                                Console.WriteLine("It's a draw!");
                            }
                            else if (computer == "PAPER" || computer == "LIZARD")
                            {
                                Console.WriteLine("You lose!");
                                scoreCPU++;
                            }
                            else
                            {
                                Console.WriteLine("You win!");
                                scorePlayer++;
                            }
                            break;


                    }
                }
                if (scorePlayer == 2)
                {
                    Console.WriteLine("Player won!");
                }
                else if (scoreCPU == 2)
                {
                    Console.WriteLine("Computer Won");
                }
                else
                {

                }

                Console.Write("Would you like to play again Y/N: ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }

            Console.WriteLine("Thanks for playing");

        }
    }
}
