using System;
using System.Collections.Generic;
using System.Text;

namespace GuessingGame
{
    class GameEngine
    {
        Random rnd = new Random();
        public int Selected_Num(int userInput)
        {
            int userInput1 = userInput + 1;
            int Ai_number = rnd.Next(1, userInput1);
            return Ai_number;
        }

        public void Engine(int Ai_number, int UserGuesses)
        {
            bool won = false;
            int GuessNumber = 0;
            int lives = UserGuesses - GuessNumber;


            while (won == false)
            {
                if (lives > 0)
                {
                    Console.Write("\n\nEnter your guess: ");
                    int guess = int.Parse(Console.ReadLine());

                    if (guess == Ai_number)
                    {
                        Console.WriteLine($"\n\nYou have guessed the magic number {Ai_number}!\n\nYou guessed it in {GuessNumber} tries!");
                        won = true;
                    }
                    else if (guess > Ai_number)
                    {
                        GuessNumber++;
                        lives--;
                        Console.WriteLine($"\n\nYou guessed {guess}, which is too high! Try a lower number!\n\nYou have {lives} tries left!");

                    }
                    else if (guess < Ai_number)
                    {
                        GuessNumber++;
                        lives--;
                        Console.WriteLine($"\n\nYou guessed {guess}, which is too low! Try a higher number!\n\nYou have {lives} tries left!");
                    }
                    else
                    {
                        throw new Exception();
                    }
                }
                else
                {
                    Console.WriteLine("\n\n\nYou lost the game!\n\n\n");
                    won = true;
                }
            }


        }

    }
}

