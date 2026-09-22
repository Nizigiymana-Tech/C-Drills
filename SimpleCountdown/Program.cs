using System;

class Program
{
    static void Main()
    {
        int count = 5;

        Console.WriteLine(count + " Left!");

        while (count > 1)
        {
            count -= 1;
            Console.WriteLine(count + " Left!");
        }
        
        Console.WriteLine("Blastoff!");
    }
}