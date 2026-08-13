namespace Inheritance.PA203
{
    internal class Car : Vehicle
    {
        private decimal _fuelCapacityLiters;
        public decimal FuelCapacityLiters
        {
            get
            {
                return _fuelCapacityLiters;
            }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Yanacaq tutumu 0-dan kicik ola bilməz");
                }
                _fuelCapacityLiters = value;
            }
        }

        private decimal _fuelLiters;
        public decimal FuelLiters
        {
            get
            {
                return _fuelLiters;
            }
            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Yanacaq miqdarı 0-dan kicik ola bilməz");
                }
                _fuelLiters = value;
            }
        }
        private decimal _fuelConsumptionPer100Km;
        private bool IsRunning;

        public decimal FuelConsumptionPer100Km
        {
            get
            {
                return _fuelConsumptionPer100Km;
            }
            set
            {
                if (value<=0)
                {
                    Console.WriteLine("Gedilen yol 0-dan kicik ola bilməz");
                }
                _fuelConsumptionPer100Km = value;
            }
        }

        public Car(string model, string brand, int year, decimal fuelCapacityLiters, decimal fuelLiters, decimal fuelConsumptionPer100Km)
            : base(model, brand, year)
        {
            FuelCapacityLiters = fuelCapacityLiters;
            FuelLiters = fuelLiters;
            FuelConsumptionPer100Km = fuelConsumptionPer100Km;
        }
        public void Refuel(decimal liters)
        {
            if (liters <= 0)
            {
                Console.WriteLine("Yanacaq miqdarı 0-dan kicik ola bilməz");
                return;
            }
            if (FuelLiters + liters > FuelCapacityLiters)
            {
                Console.WriteLine("Yanacaq tutumu limitin kecilib ");
                return;
            }
            FuelLiters += liters;
        }
        public override void Drive(int km)
        {
            if (km <= 0)
                return;

            if (!IsRunning)
                return;

            decimal requiredLiters = (km / 100) * FuelConsumptionPer100Km;

            if (FuelLiters < requiredLiters)
            {
                Console.WriteLine("Yanacaq kifayet deyil.");
                return;
            }

            FuelLiters -= requiredLiters;
            MileageKm += km;
        }
        public override void VehicleInfo()
        {
            base.VehicleInfo();
            Console.WriteLine($"Yanacaq tutumu: {FuelCapacityLiters} L");
            Console.WriteLine($"Yanacaq miqdarı: {FuelLiters} L");
            Console.WriteLine($"Yanacaq sərfiyyatı: {FuelConsumptionPer100Km} L/100km");
            Console.WriteLine($"Fuel: {FuelLiters:F1}L / {FuelCapacityLiters:F1}L");
        }



    }
}
