namespace Inheritance.PA203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("BMW", "X5", 2020, 80, 50, 10);
            ElectricCar electricCar = new ElectricCar("Tesla", "Model S", 2021, 100, 80, 20);
            Vehicle vehicle = new Vehicle("Toyota", "Camry", 2022);
            car.VehicleInfo();


            car.StartEngine();
            car.Drive(100);
            car.Refuel(15);
            car.VehicleInfo();
            car.StopEngine();

            Console.WriteLine();

            electricCar.StopEngine();
            electricCar.VehicleInfo();
            electricCar.StartEngine();
            electricCar.Drive(100);


            vehicle.VehicleInfo();
            vehicle.StopEngine();
            vehicle.StartEngine();
        }
    }
}