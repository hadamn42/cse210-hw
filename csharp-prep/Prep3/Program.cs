using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        // string MagicNumber;
        int MagicInt = randomGenerator.Next(1, 10);
        string guess;
        int GuessInt;
        int i = 1;

        // Console.WriteLine("What is the magic number? ");
        // MagicNumber = Console.ReadLine();
        // MagicInt = int.Parse(MagicNumber);

        do
        {
            Console.WriteLine("What is your guess? ");
            guess = Console.ReadLine();
            GuessInt = int.Parse(guess);

            if (GuessInt == MagicInt)
            {
                if (i > 1)
                {
                    Console.WriteLine($"Correct! It took {i} guesses. ");
                }
                else
                {
                    Console.WriteLine($"Correct! It took {i} guess. ");
                }
            }
            else if (GuessInt > MagicInt)
            {
                Console.WriteLine("Lower. ");
            }
            else if (GuessInt < MagicInt)
            {
                Console.WriteLine("Higher. ");
            }
            else
            {
                Console.WriteLine("That is not a guess try again. ");
            }
            i += 1;
        } while (GuessInt != MagicInt);
    }
}