using System;

namespace Class3_Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program for user to win if she picks/guesses the number 8. All other guesses result in a loss.
            Console.Write("Hello, there. Pick a whole number from 1 through 10 " +
               "to see if you can guess the number I'm thinking of: ");
            /*userGuess variable is the number chosen by the user*/
            string userGuess = Console.ReadLine();

            /*Used in-line conditional operator because there is only one correct guess
             to win this game.*/
            string message = (userGuess == "8") ? "You Win!" : "You Lose";
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
