namespace Qəhvə_Maşını_Sistemi
{
    internal class CoffeeMaker
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        private int _year;
        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1950)
                {
                    Console.WriteLine("Year 1950-dan kiçik ola bilməz");
                }
                _year = value;
            }
        }
        public int TotalCupsMade { get; set; } = 0;
        public bool IsReady { get; set; } = false;

        public CoffeeMaker(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }
        public void PowerOn()
        {
            IsReady = true;
            Console.WriteLine("Qəhvə maşını işə düşdü");
        }
        public void PowerOff()

        {
            IsReady = false;
            Console.WriteLine("Qəhvə maşını söndürüldü");
        }
        public virtual void Brew(int cups)
        {
            if (cups<0)
            {
                Console.WriteLine("Qəhvə fincanlarının sayı 0-dan böyük olmalıdır.");
                return;
            }
            if (!IsReady)
            {
                Console.WriteLine("Qəhvə maşını hazır deyil. Zəhmət olmasa əvvəlcə onu işə salın.");
                return;
            }
            TotalCupsMade += cups;
            Console.WriteLine($"{cups} fincan qəhvə hazırlandı. Ümumi hazırlanmış fincan sayı: {TotalCupsMade}");
        }
        public virtual void DeviceInfo()
        {
            Console.WriteLine($"Type: Coffee Maker");
            Console.WriteLine($"Brend: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"İl: {Year}");
            Console.WriteLine($"Ümumi hazırlanmış fincan sayı: {TotalCupsMade}"); 
        }
    }
}
