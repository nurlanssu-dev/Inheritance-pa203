namespace Qəhvə_Maşını_Sistemi
{
    internal class EspressoMachine : CoffeeMaker
    {
        private double _waterCapacityMl;
        public double WaterCapacityMl
        {
            get { return _waterCapacityMl; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Su tutumu 0-dan böyük olmalıdır.");
                }
                else
                {
                    _waterCapacityMl = value;
                }
            }
        }
        private double _currentWaterMl;
        public double CurrentWaterMl
        {
            get { return _currentWaterMl; }
            set
            {
                if (value < 0 && value > WaterCapacityMl)
                {
                    Console.WriteLine("Cari su miqdarı 0-dan böyük və WaterCapacityMl-dən kiçik olmalıdır.");
                }
                else
                {
                    _currentWaterMl = value;
                }
            }
        }
        private double _beanCapacityGr;
        public double BeanCapacityGr
        {
            get
            {
                return _beanCapacityGr;
            }
            set
            {
                if (value < 0 && value > BeanCapacityGr)
                {
                    Console.WriteLine("kofe tutumu 0-dan böyük və BeanCapacityGr-dən kiçik olmalıdır.");
                }
                else
                {
                    _beanCapacityGr = value;
                }
            }

        }
        private double _currentBeansGr;
        public double CurrentBeansGr
        {
            get { return _currentBeansGr; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Cari kofe miqdarı 0-dan böyük olmalıdır.");
                }
                else
                {
                    _currentBeansGr = value;
                }
            }
        }
        private double _waterPerCupMl;
        public double WaterPerCupMl
        {
            get { return _waterPerCupMl; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Hər fil kofe üçün su miqdarı 0-dan böyük olmalıdır.");
                }
                else
                {
                    _waterPerCupMl = value;
                }
            }
        }
        private double _beansPerCupGr;
        public double BeansPerCupGr
        {
            get { return _beansPerCupGr; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Hər fil kofe üçün kofe miqdarı 0-dan böyük olmalıdır.");
                }
                else
                {
                    _beansPerCupGr = value;
                }
            }
        }

        public EspressoMachine(string brand, string model, int year, double waterCapacityMl, double beanCapacityGr, double waterPerCupMl, double beansPerCupGr, double currentWaterMl, double currentBeansGr) : base(brand, model, year)
        {
            WaterCapacityMl = waterCapacityMl;
            BeanCapacityGr = beanCapacityGr;
            WaterPerCupMl = waterPerCupMl;
            BeansPerCupGr = beansPerCupGr;
            CurrentWaterMl = currentWaterMl;
            CurrentBeansGr = currentBeansGr;
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
            double requiredWater = cups * WaterPerCupMl;
            double requiredBeans = cups * BeansPerCupGr;
            if (CurrentWaterMl < requiredWater)
            {
                Console.WriteLine("Kifayət qədər su yoxdur. Zəhmət olmasa su əlavə edin.");
                return;
            }
            if (CurrentBeansGr < requiredBeans)
            {
                Console.WriteLine("Kifayət qədər kofe yoxdur. Zəhmət olmasa kofe əlavə edin.");
                return;
            }
            CurrentWaterMl -= requiredWater;
            CurrentBeansGr -= requiredBeans;
            TotalCupsMade += cups;
            Console.WriteLine($"{cups} fincan espresso hazırlandı. Ümumi hazırlanmış fincan sayı: {TotalCupsMade}");
        }
        public override void DeviceInfo()
        {
            base.DeviceInfo();
            Console.WriteLine($"Su tutumu (ml): {WaterCapacityMl}");
            Console.WriteLine($"Cari su miqdarı (ml): {CurrentWaterMl}");
            Console.WriteLine($"Kofe tutumu (gr): {BeanCapacityGr}");
            Console.WriteLine($"Cari kofe miqdarı (gr): {CurrentBeansGr}");
            Console.WriteLine($"Hər fincan üçün su miqdarı (ml): {WaterPerCupMl}");
            Console.WriteLine($"Hər fincan üçün kofe miqdarı (gr): {BeansPerCupGr}");
        }

    }
}
