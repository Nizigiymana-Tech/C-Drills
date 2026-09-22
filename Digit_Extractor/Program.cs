using System;

class Program
{
    static void Main()
    {
        int number = 1234;

        while (number > 0)
        {
            Console.WriteLine(number % 10);
            number = number / 10;
        }

        Console.WriteLine(number);
    }
}
