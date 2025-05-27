# Bank Account Manager

## Goals
Class <code>BankAccount</code> with deposit/withdraw and private balance.

### Steps:
- Menu: (1) Create account (2) Deposit (3) Withdraw (4) Check balance.
- Prevent negative balance.
- Use encapsulation (<code>private</code> + methods).

<br/><br/><br/>

# 🧠 Practice Tasks
🔹 1. Prevent Multiple Account Creation

    Right now, a user can create a new account any time. Change it so that:

        If an account already exists, the user is warned.

        Prevent overwriting the current account unless confirmed.

🔹 2. Add Account Holder Name

    Add a private string accountHolder field.

    Set it during account creation.

    Display it when checking balance (e.g., “Balance for John Doe: 100.00 kr”).

🔹 3. Add Transaction History

    Store each deposit/withdrawal in a private List<string> transactions.

    Add methods:

        ShowTransactionHistory() — display all transactions.

🔹 4. Add PIN Security

    When creating an account, set a 4-digit PIN.

    Before Deposit, Withdraw, or Balance Check, ask for the correct PIN.

    Use a private field like private string pin; and a method like bool VerifyPin(string inputPin).

🔹 5. Limit Withdrawals per Day (Challenge)

    Create a limit of 3 withdrawals per day.

    Track withdrawals using a private field: private int dailyWithdrawCount;

    Reset it on a new day (optional advanced: use DateTime to track date).

🔹 6. Add Interest (Advanced)

    Create a method: ApplyInterest(decimal rate) that adds interest to the balance.

    For example: account.ApplyInterest(0.05m); → adds 5% to current balance.

📌 Extra Bonus Task

Create a Bank class that can manage multiple BankAccount instances with different names. Let users:

    Create multiple accounts with unique names.

    Select which account to operate on by name.