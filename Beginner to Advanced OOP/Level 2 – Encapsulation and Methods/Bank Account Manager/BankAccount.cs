namespace BankAccountManagerApp;

class BankAccount
{
    private double balance { get; set; }

    public void Deposit(double amount)
    {
        if( amount < 0)
        {
            Console.WriteLine($"Can not deposite negative amount.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Successfully deposited: {amount}.");
    }

    public double Withdraw(double amount)
    {
        if (balance < 0)
        {
            Console.WriteLine($"Can not withdraw from empty balance.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine($"You can not withdraw more than your balance.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Successfully withdrawed: {amount}.");

        return amount;
    }
}