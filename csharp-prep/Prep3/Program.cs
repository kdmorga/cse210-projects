using System;

class Program
{
    static void Main(string[] args)
    {
       Random randomGenerator = new Random();
       int magicNumber = randomGenerator.Next(1, 101);

    int guess = -1;


       while (guess != magicNumber)
       {
        Console.WriteLine("Welcome to the Guess my Number Game!");
        Console.Write("What is your guess?");
        guess = int.Parse(Console.ReadLine());

        if (magicNumber > guess)
        {
            Console.WriteLine("Higher");
        }
        else if (magicNumber < guess)
        {
            Console.WriteLine("Lower");

        }
        else
        {
            Console.WriteLine("You guessed the number!");
        }

       }


    }
}