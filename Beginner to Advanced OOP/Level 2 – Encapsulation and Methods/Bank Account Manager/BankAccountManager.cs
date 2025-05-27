namespace BankAccountManagerApp;

class BankAccountManager
{
    private readonly List<BankAccount> accounts = new List<BankAccount>();


    public void CreateAccount()
    {
        BankAccount newAccount = new BankAccount();
        accounts.Add(newAccount);
    }

    public void Deposit(double amount)
    {

    }
}