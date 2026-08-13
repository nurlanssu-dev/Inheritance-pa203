namespace Bank_Sistemi
{
    internal class SavingsAccount : BankAccount
    {
        public double InterestRate { get; set; }
        public int WithdrawLimit { get; set; }
        public int CurrentWithdrawals { get; set; }

        public SavingsAccount(string holderName, string accountNumber, double initialBalance, string currency, double interestRate, int withdrawLimit) : base(holderName, accountNumber, initialBalance, currency)
        {
            InterestRate = interestRate;
            WithdrawLimit = withdrawLimit;
            CurrentWithdrawals = 0;
        }
        public void ApplyInterest() //Balansın üzərinə faiz qədər məbləğ gəlir
        {
            if (Balance > 0)
            {
                double interest = Balance * InterestRate / 100;
                Balance += interest;
                AddLog($"Interest Applied: {interest} {Currency}");
            }
        }
        public override void Withdraw(double amount) //Günlük çıxarış limiti və balansın kifayət olub-olmamasını yoxlayır
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
            if (CurrentWithdrawals >= WithdrawLimit)
            {
                Console.WriteLine("Günlük çıxarış limiti aşıldı. emeliyyat aparılmır.");
                return;
            }
            if (Balance - amount < 0)
            {
                Console.WriteLine("Balans kifayət deyil. emeliyyat aparılmır.");
                return;
            }
            Balance -= amount;
            CurrentWithdrawals++;
            AddLog($"Withdrawn : {amount} {Currency}");
        }
        public void ResetWithdrawals() 
        {
            CurrentWithdrawals = 0;
        }
        public override void AccountInfo()
        {
            base.AccountInfo();
            Console.WriteLine($"Interest Rate: {InterestRate}%");
            Console.WriteLine($"Withdraw Limit: {WithdrawLimit}");
            Console.WriteLine($"Current Withdrawals: {CurrentWithdrawals}");
        }

    }
}
