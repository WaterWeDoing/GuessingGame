using System;

namespace GuessingGame
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            GameEngine user = new GameEngine();
            int UserInput = UserNum();
            int UserGuesses = UserGuess();
            int Ai_number = user.Selected_Num(UserInput);
            user.Engine(Ai_number, UserGuesses);

        }

        static int UserGuess()
        {         
            Console.Write("Enter the number of attempts you want: ");
            int userGuesses = int.Parse(Console.ReadLine());
            return userGuesses;
        }

        static int UserNum()
        {
            Console.Write("\n\nEnter a number to guess up to: ");
            int userInput = int.Parse(Console.ReadLine());
            return userInput;
        }
        
        


    }
}
