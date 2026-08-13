namespace Qəhvə_Maşını_Sistemi
{
    internal class CapsuleMachine : CoffeeMaker
    {
        private double _maxCapsuleCapacity;
        public double MaxCapsuleCapacity
        {
            get { return _maxCapsuleCapacity; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Kapsul tutumu 0-dan böyük olmalıdır.");
                }
                else
                {
                    _maxCapsuleCapacity = value;
                }
            }
        }
        private double _currentCapsules;
        public double CurrentCapsules
        {
            get
            {
                return _currentCapsules;
            }
            set
            {
                if (value < 0 && value > MaxCapsuleCapacity)
                {
                    Console.WriteLine("Cari kapsul sayı 0-dan  böyük MaxCapsuleCapacity tutumundan kicik olmalıdır.");
                }
                else
                {
                    _currentCapsules = value;
                }
            }
        }
        public bool HasMilkFrother { get; set; }


        public CapsuleMachine(string brand, string model, int year, double maxCapsuleCapacity, double currentCapsules, bool hasMilkFrother) : base(brand, model, year)
        {
            MaxCapsuleCapacity = maxCapsuleCapacity;
            CurrentCapsules = currentCapsules;
            HasMilkFrother = hasMilkFrother;
        }
        public void InsertCapsules(double count)
        {
            if (count < 0)
            {
                Console.WriteLine("Kapsul sayı 0-dan böyük olmalıdır.");
                return;
            }
            if (CurrentCapsules + count > MaxCapsuleCapacity)
            {
                Console.WriteLine("Kapsul tutumu aşıldı. Zəhmət olmasa daha az kapsul daxil edin.");
                return;
            }
            CurrentCapsules += count;
        }
        public override void Brew(int cups)
        {
            if (cups < 0)
            {
                Console.WriteLine("Qəhvə fincanlarının sayı 0-dan böyük olmalıdır.");
                return;
            }
            if (!IsReady)
            {
                Console.WriteLine("Qəhvə maşını hazır deyil. Zəhmət olmasa əvvəlcə onu işə salın.");
                return;
            }
            if (CurrentCapsules < cups)
            {
                Console.WriteLine("Kapsul sayı kifayət deyil. Zəhmət olmasa daha çox kapsul əlavə edin.");
                return;
            }
            CurrentCapsules -= cups;
            TotalCupsMade += cups;
            Console.WriteLine($"{cups} fincan qəhvə hazırlandı. Ümumi hazırlanmış fincan sayı: {TotalCupsMade}");
        }
        public override void DeviceInfo()
        {
            base.DeviceInfo();
            Console.WriteLine($"Max Capsule Capacity: {MaxCapsuleCapacity}");
            Console.WriteLine($"Current Capsules: {CurrentCapsules}");
            Console.WriteLine($"Has Milk Frother: {HasMilkFrother}");
        }
    }
}
