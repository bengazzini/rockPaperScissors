using System;
using System.Collections.Generic;

namespace rockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            string winner = "You win, winner!";
            string loser = "Not today, loser!";
            var random = new Random();
            bool tryAgain = true;
            int winCountUser = 0;
            int winCountComp = 0;

            //Response from computer.
            List<string> opponentResponse = new List<string>();
            opponentResponse.Add("Rock");
            opponentResponse.Add("Paper");
            opponentResponse.Add("Scissors");

            Console.WriteLine("It's time to play some Rock, Paper, Scissors! First to three victories wins!");
            do
            {
                int index = random.Next(opponentResponse.Count);
                Console.WriteLine("Rock, Paper, Scissors, shoot! (Type Rock, Paper, or Scissors)");

                var userResponse = Console.ReadLine();
                userResponse = userResponse.ToLower();
                if (userResponse != null)
                {
                    Console.WriteLine("Computer: " + opponentResponse[index]);
                    var actualResponse = opponentResponse[index];
                    if (userResponse == actualResponse.ToLower())
                    {
                        Console.WriteLine("Draw! Try again!");
                    }
                    //lose game
                    if (userResponse == "rock" && actualResponse == "Paper" ||
                        userResponse == "paper" && actualResponse == "Scissors" ||
                        userResponse == "scissors" && actualResponse == "Rock")
                    {
                        Console.WriteLine(loser);
                        winCountComp++;
                    }
                    //win game
                    else if (userResponse == "rock" && actualResponse == "Scissors" ||
                        userResponse == "paper" && actualResponse == "Rock" ||
                        userResponse == "scissors" && actualResponse == "Paper")
                    {
                        Console.WriteLine(winner);
                        winCountUser++;
                    }
                    if (winCountUser == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("By Azura by Azura by Azura! You're the grand champion!");
                        tryAgain = false;
                    }
                    else if (winCountComp == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Hang your head in shame, LOSER!");
                        tryAgain = false;
                    }
                }
            } while (tryAgain == true && winCountComp < 3 || tryAgain == true && winCountUser < 3);
            Console.ResetColor();
        }
    }
}
