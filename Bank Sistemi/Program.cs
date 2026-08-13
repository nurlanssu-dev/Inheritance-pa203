namespace Bank_Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditAccount credit = new CreditAccount("Əli Əliyev", "AZ1001", 50, "AZN", 500, 10);
            credit.Withdraw(100);
            credit.ApplyPenalty();
            credit.AccountInfo();
            credit.ShowHistory();

            SavingsAccount savings = new SavingsAccount("Vəli Vəliyev", "AZ1002", 1000, "USD", 5, 2);
            savings.Deposit(200);
            savings.Withdraw(100);
            savings.ApplyInterest();
            savings.AccountInfo();
            savings.ShowHistory();


            CorporateAccount corp = new CorporateAccount("Zaur Məmmədov", "AZ1003", 5000, "EUR", "Tech MMC", 2.5);
            corp.Withdraw(1000);
            corp.AccountInfo();
            corp.ShowHistory();
        }
    }
}
