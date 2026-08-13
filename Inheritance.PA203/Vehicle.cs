namespace Inheritance.PA203
{
    public class Vehicle
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        private int _year;

        public int Year
        {
            get
            {
                return _year;
            }
            set
            {
                if (value < 1886)
                {
                    Console.WriteLine("Year 1886-dan kiçik ola bilməz");
                }

                _year = value;
            }
        }

       
        public decimal MileageKm { get; set; } = 0;
        public int MyProperty { get; set; }
        public bool IsRunnig { get; set; } = false;

        public Vehicle(string model, string brand, int year)
        {
            Model = model;
            Brand = brand;
            Year = year;
        }
        public void StartEngine()
        {
            IsRunnig = true;
        }
        public void StopEngine()
        {
            IsRunnig = false;
        }
        public virtual void Drive(int km)
        {
            if (km < 0)
            {
                Console.WriteLine("km 0-dan kicik ola bilmez");
                return;
            }
            if (!IsRunnig)
            {
                Console.WriteLine("masin islemir");
                return;
            }
            MileageKm += km;
        }
        public virtual void VehicleInfo()
        {
            Console.WriteLine("Type: Vehicle");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Mileage: {MileageKm} km");
            Console.WriteLine($"Is Running: {IsRunnig}");
        }


    }
}
