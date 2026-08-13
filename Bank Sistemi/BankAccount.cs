namespace Bank_Sistemi;

internal class BankAccount
{
    public string HolderName { get; set; }
    public string AccountNumber { get; set; }
    public double Balance { get; set; }
    public string Currency { get; set; }
    public bool IsActive { get; set; } = true;
    public string[] TransactionHistory { get; set; }
    public int TransactionCount { get; set; } = 0;

    public BankAccount(string holderName, string accountNumber, double initialBalance, string currency)
    {
        HolderName = holderName;
        AccountNumber = accountNumber;
        if (initialBalance < 0)
        {
            Balance = 0;
        }
        else
        {
            Balance = initialBalance;
        }
        Currency = currency;
        TransactionHistory = new string[100];
        TransactionHistory[0] = $"Account Created with {Balance} {Currency}";
        TransactionCount++;
    }
    public void AddLog(string message)
    {
        if (TransactionCount < TransactionHistory.Length)
        {
            TransactionHistory[TransactionCount] = message;
            TransactionCount++;
        }
        else
        {
            Console.WriteLine("TransactionHistory doludur");
        }

    }
    public void BlockAccount()
    {
        IsActive = false;
        AddLog("Account Blocked");
    }
    public void UnblockAccount()
    {
        IsActive = true;
        AddLog("Account Unblocked");
    }
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("meble 0-dan böyük olmalıdır");
            return;
        }
        if (!IsActive)
        {
            Console.WriteLine("hesab blok edilib. Əməliyyat aparılmır.");
            return;
        }
        Balance += amount;
        AddLog($"Deposited : {amount} {Currency}");
    }
    public virtual void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("meble 0-dan böyük olmalıdır");
            return;
        }
        if (!IsActive)
        {
            Console.WriteLine("hesab blok edilib. Əməliyyat aparılmır.");
            return;
        }
        if (Balance < amount)
        {
            Console.WriteLine("Balansda kifayet qeder pul yoxdur");
            return;
        }
        Balance -= amount;
        AddLog($"Withdrawn : {amount} {Currency}");
    }
    public void ShowHistory()
    {
        Console.WriteLine("Transaction History:");
        for (int i = 0; i < TransactionCount; i++)
        {
            Console.WriteLine(TransactionHistory[i]);
        }
    }
    public virtual void AccountInfo()
    {
        Console.WriteLine($"Type: Bank Account");
        Console.WriteLine($"Holder: {HolderName}");
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Balance: {Balance}");
        Console.WriteLine($"Currency: {Currency}");
        Console.WriteLine($"Status: {(IsActive ? "Active" : "Blocked")}");
    }
}
