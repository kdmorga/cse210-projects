using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();



        int sum = 0;
        foreach (int number in numbers)
        {

            sum += number;
        }


        Console.WriteLine($"The Sum is: {sum}");

   

    float average = ((float)sum) / numbers.Count;
    Console.WriteLine($"The average is : {average}");



    int max = numbers[0];
    foreach (int number in numbers)
    {
        if (number> max)
        {
            max = number;
        }
    }


    Console.WriteLine($"The max is : {max}");







 }
}