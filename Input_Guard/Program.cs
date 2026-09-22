using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        while (number <= 0)
        {
            Console.Write("Number is less than 0, Try again: ");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Thank you! You entered: {number}");
    }
}
