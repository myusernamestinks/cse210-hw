using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Please enter a series of numbers, type 0 when done.");

        int number;
        do
        {
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out number))
            {
                numbers.Add(number);
            }


        } while (number != 0);

        Console.WriteLine($"The sum is: {numbers.Sum()}");
        Console.WriteLine($"The average is: {numbers.Average()}");
        Console.WriteLine($"The largest number is: {numbers.Max()}");

        List<int> positiveNumbers = numbers.Where(n => n > 0).ToList();
        Console.WriteLine($"The Smallest postive number is: {positiveNumbers.Min()}");

        List<int> sortedList = numbers.OrderBy(n => n).ToList();
        Console.WriteLine("The sorted list is: ");
        foreach (int sortedNumber in sortedList)
        {
            Console.WriteLine(sortedNumber);
        }

    }
}