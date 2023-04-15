using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Enter your move: rock, paper, or scissors?");
        string playerMove = Console.ReadLine().ToLower();

        Console.WriteLine("Enter opponent's move: rock, paper, or scissors?");
        string opponentMove = Console.ReadLine().ToLower();

       
        if (playerMove == opponentMove)
        {
            Console.WriteLine("It's a draw!");
        }
        else if ((playerMove == "rock" && opponentMove == "scissors") || 
                 (playerMove == "scissors" && opponentMove == "paper") ||
                 (playerMove == "paper" && opponentMove == "rock"))
        {
            Console.WriteLine("You win!");
        }
        else
        {
            Console.WriteLine("Opponent wins!");
        }

        Console.ReadLine();
    }
}
