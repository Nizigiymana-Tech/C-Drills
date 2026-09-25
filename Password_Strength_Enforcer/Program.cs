using System.Text;
using System.Threading.Tasks;

class Program
{
    static async Task Main()
    {
        Console.WriteLine("This is a Password Strength Enforcer.");
        Console.WriteLine("If you want a strong password you must use these criteria.");
        Console.WriteLine("1. At least 8 characters long.");
        Console.WriteLine("2. Contains at least one uppercase letter.");
        Console.WriteLine("3. Contains at least one digit.");
        Console.Write("What is your password: ");

        bool Done = false;
        Console.WriteLine();

        while (!Done)
        {
            var result = await CheckPassword();
            bool meetsCriteria = result.IsSuccess;

            if (meetsCriteria)
            {
                Console.WriteLine("Thank you for completing the Password Strength Enforcer. Goodbye.");
                break;
            } else {
                string Reason = result.Message;
                Console.WriteLine("Sorry, the password you provided cannot be validated. The reason is: " + Reason + " Please try again: ");
            }
        }
    }

     static public async Task<(bool IsSuccess, string Message)> CheckPassword()
    {
        bool loading = false;
        string? password = null;
        Random random = new Random();

        while (true)
        {
            var key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Enter)
            {
                break;
            }

            password += key.KeyChar;
        }

        loading = true;

        var animation = Task.Run(async () => {
            Console.Write("Loading");

            while (loading) {
                Console.Write(".");
                await Task.Delay(500);
            }

        });

        if (string.IsNullOrEmpty(password) || string.IsNullOrWhiteSpace(password))
        {
            int randomNumber = random.Next(2000, 5000);
            await Task.Delay(randomNumber);
            loading = false;
            Console.WriteLine();
            return (false, "The password you provided is empty. Or, has WhiteSpaces in it.");
        }

        int Number = 0;

        if (password.Length < 8)
        {
            int randomNumber = random.Next(2000, 5000);
            await Task.Delay(randomNumber);
            loading = false;
            Console.WriteLine();
            return (false, "Your password length is below 8.");
        }

        foreach (char ch in password)
        {
            if (char.IsUpper(ch))
            {
                break;
            }

            Number += 1;
        }

        if (password.Length == Number)
        {
            int randomNumber = random.Next(2000, 5000);
            await Task.Delay(randomNumber);
            loading = false;
            Console.WriteLine();
            return (false, "The password has no uppercase letters inside.");
        }

        Number = 0;

        foreach (char ch in password)
        {
            if (char.IsDigit(ch))
            {
                break;
            }

            Number += 1;
        }

        if (password.Length == Number)
        {
            int randomNumber = random.Next(2000, 5000);
            await Task.Delay(randomNumber);
            loading = false;
            Console.WriteLine();
            return (false, "The password has no numbers inside.");
        }
        
        int randomNumber2 = random.Next(2000, 5000);
        await Task.Delay(randomNumber2);
        loading = false;

        return (true, "Good Job!");
    }
}
