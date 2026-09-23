using System;

class Program
{
    static void Main()
    {
        int OG = 6;
        int positiveInteger = 6;
        int steps = 0;
        
        while (positiveInteger != 1)
        {
            steps += 1;

            if (positiveInteger % 2 != 0)
            {
                positiveInteger = (positiveInteger * 3 + 1);
            } else {
                positiveInteger /= 2;
            }

            Console.WriteLine(positiveInteger);
        }

        Console.WriteLine("It took " + steps + " Steps to make " + OG + " To equal 1!");
    }
}