using System;

namespace GuessTheNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(20);
            bool keepIteration = true;

            Console.WriteLine("Guess the Number !!");
            Console.WriteLine("Between 0 to 20");
            Console.WriteLine("Enter your guess, or -1 to give up");

            int guessNum = 0;
            int guessCount = 0;

            do
            {
                Console.WriteLine("What's your guess?");
                string theGuess = Console.ReadLine();
                bool result = Int32.TryParse(theGuess, out guessNum);

                if (!result)
                {
                    Console.WriteLine("Wrong Guess. Try Again.");
                }
                else
                {
                    if (guessNum == -1)
                    {
                        Console.WriteLine($"I was thinking of {number}");
                        keepIteration = false;
                    }
                    else
                    {
                        guessCount++;

                        if (guessNum == number)
                        {
                            Console.WriteLine($"You got it in {guessCount} guesses!!");
                            keepIteration = false;
                        }
                        else
                        {
                            Console.WriteLine("Nope, {0} than that.", guessNum < number ? "higher" : "lower");
                        }
                    }
                }

            } while (keepIteration);
            Console.ReadLine(); 

        }
    }
}
