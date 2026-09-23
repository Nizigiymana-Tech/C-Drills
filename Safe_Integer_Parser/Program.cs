using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string? input = Console.ReadLine();
        
        int result;

        while (!int.TryParse(input, out result))
        {
            Console.Write("Invalid integer, try again: ");
            input = Console.ReadLine();
        }

        Console.WriteLine($"Successfully parsed: {result}");
    }
}
