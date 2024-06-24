using System.Reflection.Metadata.Ecma335;

namespace task2_20_06
{
    public class Car
    {
        public double Mileage { get; set; }
        public double Fuel { get; set; }
        public double FuelConsumption { get; set; }
        public double TankCapacity { get; set; }

        public Car(double mileage, double fuel, double tankCapacity, double fuelConsumption)
        {
            Mileage = mileage;
            Fuel = fuel;
            TankCapacity = tankCapacity;
            FuelConsumption = fuelConsumption;

        }

        public Car()
        {
            Fuel = 20;
            TankCapacity = 40;
            FuelConsumption = 10;
        }


        public bool Drive(double kilometer)
        {
            double needFuel = kilometer * FuelConsumption / 100;
            
            if (needFuel > Fuel)
            {
                Console.WriteLine("Fuel insufficient for desired distance");
                return false;

            }
            return true;

        }

        public bool Refuel(double amount)
        {
            double FuelNeededToAdd = TankCapacity - Fuel;
            if (amount > FuelNeededToAdd)
            {
                return false;
            }
            Fuel += amount;
            return true;
        }

        public void ShowFuel()
        {
            Console.WriteLine($"Fuel: {Fuel}");
        }

        public void ShowMileage()
        {
            Console.WriteLine($"Mileage: {Mileage}");
        }
    }
    
}
