using BankAccountManagerApp;

Console.WriteLine("Bank Account Manager");
Console.WriteLine("Bank Account with deposit/withdraw and private balance.");

BankAccount account = null;

while (true)
{
    Console.WriteLine("\n--- Bank Menu ---");
    Console.WriteLine("1. Create Account");
    Console.WriteLine("2. Deposite");
    Console.WriteLine("3. Withdraw");
    Console.WriteLine("4. Check Balance");
    Console.WriteLine("5. Exit");
    Console.Write("Choose an option: ");

    string input = Console.ReadLine();

    switch (input)
    {
        case "1":
            account = new BankAccount();
            Console.WriteLine("Account created.");
            break;
        case "2":
            if (account is null)
            {
                Console.WriteLine("Create an account first.");
                break;
            }

            Console.Write("Enter deposit amount: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                account.Deposit(depositAmount);
            else
                Console.WriteLine("Invalid amount.");
            break;
        case "3":
            if (account == null)
            {
                Console.WriteLine("Create an account first.");
                break;
            }

            Console.Write("Enter withdrawal amount: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal withdrawAmount))
                account.Withdraw(withdrawAmount);
            else
                Console.WriteLine("Invalid amount.");
            break;
        case "4":
            if (account == null)
            {
                Console.WriteLine("Create an account first.");
                break;
            }

            Console.WriteLine($"Current balance: {account.GetBalance():C}");
            break;

        case "5":
            Console.WriteLine("Goodbye!");
            return;

        default:
            Console.WriteLine("Invalid option.");
            break;
    }
}
