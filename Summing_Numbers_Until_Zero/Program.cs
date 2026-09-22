using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main()
    {
        int total = 0;
        
        Console.Write("Enter a number (0 to quit): ");
        int input = int.Parse(Console.ReadLine()!);

        while (input != 0)
        {
            total += input;
            Console.Write("Enter a number (0 to quit): ");
            input = int.Parse(Console.ReadLine()!);
        }

        Console.WriteLine($"Total sum: {total}");
    }
}
