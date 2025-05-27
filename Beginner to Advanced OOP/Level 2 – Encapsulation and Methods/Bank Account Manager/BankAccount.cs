namespace BankAccountManagerApp;

class BankAccount
{
    private decimal balance { get; set; }

    public BankAccount()
    {
        this.balance = 0;
    }

    public void Deposit(decimal amount)
    {
        if( amount < 0)
        {
            Console.WriteLine($"Can not deposit negative amount.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (balance < 0)
        {
            Console.WriteLine($"Can not withdraw from empty balance.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine($"You can not withdraw more than your balance.");
            Console.WriteLine("Insufficient funds.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Withdrew {amount:C}. New balance: {balance:C}");
    }

    public decimal GetBalance()
    {
        return balance;
    }
}