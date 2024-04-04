using System;

class Program
{
    static string ComputerChoice()
    {
        string[] choices = { "rock", "paper", "scissors" };
        Random rand = new Random();
        return choices[rand.Next(0, choices.Length)];
    }

    static void Main(string[] args)
    {
        string userChoice;

        Console.Write("Do you want to play rock, paper scissors? (yes/no): ");
        userChoice = Console.ReadLine();

        while (userChoice.ToLower() == "yes")
        {
            string computerChoice = ComputerChoice();

            Console.Write("Rock, paper or scissors: ");
            userChoice = Console.ReadLine().ToLower();

            Console.WriteLine("Computer: " + computerChoice);

            if (userChoice == computerChoice)
            {
                Console.WriteLine("It's a draw!");
            }
            else if ((userChoice == "rock" && computerChoice == "scissors") ||
                     (userChoice == "paper" && computerChoice == "rock") ||
                     (userChoice == "scissors" && computerChoice == "paper"))
            {
                Console.WriteLine("You won!");
            }
            else
            {
                Console.WriteLine("You lost!");
            }

            Console.Write("Do you want to continue? (yes/no): ");
            userChoice = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Done!");
    }
}
