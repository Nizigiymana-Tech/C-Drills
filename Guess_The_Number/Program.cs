using System;

class Program
{
    static void Main()
    {
        int secret = 7;
        int attemptsLeft = 6;
        bool guessedCorrectly = false;
        int Guess = 0;

        while (attemptsLeft > 0 && !guessedCorrectly)
        {
            Console.Write("Guess a number: ");
            Guess = int.Parse(Console.ReadLine()!);

            if (Guess == secret)
            {
                guessedCorrectly = true;
            } else {
                attemptsLeft -= 1;
                Console.WriteLine("Wrong, remaining attempts: " + attemptsLeft);
            }
        }

        if (guessedCorrectly)
            Console.WriteLine("You win!");
        else
            Console.WriteLine("Out of attempts! You lose.");
    }
}
