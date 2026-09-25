using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter an integer: ");
        string? input = Console.ReadLine();
        
        int validnumber;

        while (!int.TryParse(input, out validnumber)) {}
        {
            Console.Write("Invalid integer, try again: ");
            input = Console.ReadLine();
        }

        Console.WriteLine($"Successfully parsed: {validnumber}");
    }
}
