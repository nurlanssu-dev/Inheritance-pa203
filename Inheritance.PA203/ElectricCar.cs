namespace Inheritance.PA203
{
    internal class ElectricCar : Vehicle
    {
        private decimal _batteryCapacityKWh;
        public decimal BatteryCapacityKWh
        {
            get
            {
                return _batteryCapacityKWh;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Batareya tutumu 0-dan boyuk olmalidir ");
                }
                _batteryCapacityKWh = value;
            }
        }


        private decimal _consumptionKWhPer100Km;
        public decimal ConsumptionKWhPer100Km
        {
            get
            {
                return _consumptionKWhPer100Km;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine(" sərfiyyatı 0-dan boyuk olmalidir ");
                }
                _consumptionKWhPer100Km = value;
            }
        }
        private decimal _initialBatteryKWh;
        public decimal InitialBatteryKWh
        {
            get
            {
                return _initialBatteryKWh;
            }
            set
            {
                if (0 <= InitialBatteryKWh && InitialBatteryKWh  <= BatteryCapacityKWh)
                {
                    Console.WriteLine("İlkin batareya tutumu 0-dan boyuk BatteryCapacityKWh kicik olmalidir ");
                }
                _initialBatteryKWh = value;
            }
        }

        public object BatteryKWh { get; private set; }

        public ElectricCar(string brand, string model, int year, decimal batteryCapacityKWh, decimal initialBatteryKWh, decimal consumptionKWhPer100Km)
       : base(brand, model, year)
        {
            BatteryCapacityKWh = batteryCapacityKWh;
            InitialBatteryKWh = initialBatteryKWh;
            ConsumptionKWhPer100Km = consumptionKWhPer100Km;
        }
        public void Charge(decimal kwh)
        {
            if (kwh < 0)
            {
                Console.WriteLine("kwh 0-dan kicik ola bilmez");
                return;
            }
            if (InitialBatteryKWh + kwh >= BatteryCapacityKWh)
            {
                Console.WriteLine("Batareya tutumu doludur");
                return;
            }
            InitialBatteryKWh += kwh;
        }
        public override void Drive(int km)
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
            decimal consumption = (ConsumptionKWhPer100Km / 100) * km;
            if (InitialBatteryKWh - consumption < 0)
            {
                Console.WriteLine("Batareya tutumu kifayet deyil");
                return;
            }
            InitialBatteryKWh -= consumption;
            MileageKm += km;
        }
        public override void VehicleInfo()
        {
            Console.WriteLine("Type: ElectricCar");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
            Console.WriteLine($"Mileage: {MileageKm} km");
            Console.WriteLine($"Battery: {BatteryKWh:F1}kWh / {BatteryCapacityKWh:F1}kWh");
        }


    }
}
