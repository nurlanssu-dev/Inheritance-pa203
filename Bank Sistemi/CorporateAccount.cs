namespace Bank_Sistemi
{
    internal class CorporateAccount : BankAccount
    {
        public string CompanyName { get; set; }
        public double TransactionFee { get; set; }

        public CorporateAccount(string holderName, string accountNumber, double initialBalance, string currency, string companyName, double transactionFee) : base(holderName, accountNumber, initialBalance, currency)
        {
            CompanyName = companyName;
            TransactionFee = transactionFee;
        }
        public override void Withdraw(double amount) //Mebleg çıxarış zamanı əməliyyat haqqını da nəzərə alır
        {
            if (amount <= 0)
            {
                Console.WriteLine("meble 0-dan böyük olmalıdır");
                return;
            }
            if (!IsActive)
            {
                Console.WriteLine("hesab blok edilib. emeliyyat aparılmır.");
                return;
            }
            double totalAmount = amount + TransactionFee;
            if (Balance - totalAmount < 0)
            {
                Console.WriteLine("Balans kifayət deyil. emeliyyat aparılmır.");
                return;
            }
            Balance -= totalAmount;
            AddLog($"Withdrew: {amount} {Currency}");
            AddLog($"Transaction Fee: -{TransactionFee}");
        }
        public override void AccountInfo()
        {
            base.AccountInfo();
            Console.WriteLine($"Company Name: {CompanyName}");
        }

    }
}
