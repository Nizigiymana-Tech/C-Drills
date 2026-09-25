using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Bank of America!");
        Console.WriteLine("Before we can start, you need a bank account!");
        
        string? playerName = GetName("Please enter your name to create your bank account: ");
        double Balance = 500.00;
        string? OldOption = "";
        
        while (OldOption != "Exit")
        {
            Console.WriteLine($"Welcome {playerName} to Bank of America!");
            Console.WriteLine($"Your current balance is ${Balance}");
            Console.WriteLine("What do you wanna do?");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Exit"); 

            string? option = GetName("Choose an option: ");
            OldOption = option;

            if (option != "Deposit" && option != "Withdraw" && option != "Exit")
            {
                Console.Write("This isn't an option, Press enter to try again: ");
                Console.ReadLine();
            }

            if (option == "Deposit")
            {
                Console.WriteLine("How much do you want to deposit. (Max is 10k), You can leave by typing 0");
                long? Amount = null;
                string? input = Console.ReadLine();

                if (long.TryParse(input, out long parsedValue))
                {
                    Amount = parsedValue;
                }

                while (Amount != 0)
                {   
                    if (Amount is null)
                    {
                        Console.Write("Sorry but, you entered nothing or letters to deposit. Please Try Again: ");
                        input = Console.ReadLine();

                        if (long.TryParse(input, out long newAmount))
                        {
                            Amount = newAmount;
                        }

                        continue;
                    }

                    if (Amount > 10000)
                    {
                        Console.Write("Sorry but, you cannot deposit anything over 10k. Try again: ");
                        input = Console.ReadLine();

                        if (long.TryParse(input, out long newAmount))
                        {
                            Amount = newAmount;
                        }

                        continue;
                    }
                    
                    Balance += Convert.ToDouble(Amount);
                    Console.Write("Deposited. Press enter to exit: ");
                    Console.ReadLine();
                    break;
                }
            }

            if (option == "Withdraw")
            {
                Console.WriteLine("How much do you want to Withdraw. You can leave by typing 0");
                long? Amount = null;
                string? input = Console.ReadLine();

                if (long.TryParse(input, out long parsedValue))
                {
                    Amount = parsedValue;
                }

                while (Amount != 0)
                {   
                    if (Amount is null)
                    {
                        Console.Write("Sorry but, you entered nothing or letters to Withdraw. Please Try Again: ");
                        input = Console.ReadLine();

                        if (long.TryParse(input, out long newAmount))
                        {
                            Amount = newAmount;
                        }

                        continue;
                    }

                    if (Amount > Balance)
                    {
                        Console.Write("Sorry but, you cannot deposit anything over your balance. Try again: ");
                        input = Console.ReadLine();

                        if (long.TryParse(input, out long newAmount))
                        {
                            Amount = newAmount;
                        }

                        continue;
                    }
                    
                    Balance -= Convert.ToDouble(Amount);
                    Console.Write("Withdrawed. Press enter to exit: ");
                    Console.ReadLine();
                    break;
                }
            }
        }
    }

    public static string GetName(string dialogue)
    {
        Console.Write(dialogue);
        string? text = Console.ReadLine();
        
        while (string.IsNullOrWhiteSpace(text) || text.Length > 26 || text.Length < 3)
        {
            if (string.IsNullOrWhiteSpace(text) || text is null)
            {
                Console.Write("Sorry, the response you gave us is nothing. try again: ");
            } else if (text.Length > 26 || text.Length < 3)  
            {
                Console.Write("Sorry, the response you gave us is above 26 letters or below 3. try again: ");
            } 

            text = Console.ReadLine();
        }

        return text;
    }
}