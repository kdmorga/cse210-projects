using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");


        Console.WriteLine("What is your grade percentage?");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);


        if (grade>= 90)
        {
            Console.WriteLine("Your grade is an A. You passed the class!");
        }
        else if (grade>= 80)
        {
            Console.WriteLine("Your grade is a B. You passed the class!");
        }
        else if (grade>= 70)
        {
            Console.WriteLine("Your grade is a C. You passed the class!");
        }
        else if (grade>= 60)
        {
            Console.WriteLine("Your grade is a D. You did not pass the class.");
        }
        else
        {
            Console.WriteLine("Your grade is an F. You did not pass the class.");
        }
    }
}