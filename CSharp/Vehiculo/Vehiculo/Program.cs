namespace Vehiculo
{
    using System;
    interface IVehiculo
    {
        void Drive();
        bool Refuel(int amount);
    }
    class Car : IVehiculo
    {
        private int gasoline;
        public Car(int startingGasoline)
        {
            gasoline = startingGasoline;
        }
        public void Drive()
        {
            if (gasoline > 0)
            {
                Console.WriteLine("The car is driving.");
            }
            else
            {
                Console.WriteLine("The car is out of gasoline.");
            }
        }
        public bool Refuel(int amount)
        {
            gasoline += amount;
            Console.WriteLine("Gasoline has been refueled.");
            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the amount of gasoline to refuel: ");
            int amount = Convert.ToInt32(Console.ReadLine());

            Car car = new Car(0);
            car.Refuel(amount);
            car.Drive();

            Console.ReadKey();
        }
    }
}