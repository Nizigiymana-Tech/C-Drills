using System;

class Program
{
    static void Main()
    {
        double balance = 1000.0;
        double interestRate = 0.05; // 5% annual interest
        double target = 2000.0;
        int years = 0;

        while (balance <= target)
        {
            years += 1;
            balance += (balance * interestRate);
        }

        Console.WriteLine($"It took " + years + " years to get " + balance + " monies");
    }
}
