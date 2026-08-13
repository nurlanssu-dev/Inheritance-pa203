namespace Bank_Sistemi
{
    internal class CreditAccount : BankAccount
    {
        public double CreditLimit { get; set; }
        public double PenaltyFee { get; set; }

        public CreditAccount(string holderName, string accountNumber, double initialBalance, string currency, double creditLimit, double penaltyFee) : base(holderName, accountNumber, initialBalance, currency)
        {
            CreditLimit = creditLimit;
            PenaltyFee = penaltyFee;
        }
        public override void Withdraw(double amount)
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
            if (Balance - amount < -CreditLimit)
            {
                Console.WriteLine("Kredit limiti aşıldı. emeliyyat aparılmır.");
                return;
            }
            Balance -= amount;
            AddLog($"Withdrawn : {amount} {Currency}");
        }
        public void ApplyPenalty()
        {
            if (Balance < 0)
            {
                Balance -= PenaltyFee;
                AddLog($"Penalty Applied: {PenaltyFee} {Currency}");
            }
        }
        public override void AccountInfo()
        {
            base.AccountInfo();

            Console.WriteLine($"Credit Limit: {CreditLimit}");
            Console.WriteLine($"Available Credit: {CreditLimit + Balance}");
        }
    }
}
