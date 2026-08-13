namespace Qəhvə_Maşını_Sistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EspressoMachine espressoMachine = new EspressoMachine("DeLonghi", "EC685", 2020, 1000, 500, 250, 100, 100, 500);
            CapsuleMachine capsuleMachine = new CapsuleMachine("Nespresso", "Pixie", 2021, 800, 400, false);
            CoffeeMaker coffeeMaker = new CoffeeMaker("Generic", "ModelX", 2022);
            coffeeMaker.PowerOn();
            espressoMachine.PowerOn();
            capsuleMachine.PowerOn();
            coffeeMaker.Brew(1);
            espressoMachine.Brew(2);
            capsuleMachine.Brew(3);

        }
    }
}
