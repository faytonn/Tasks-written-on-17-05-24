using asbdjasd;

Car car = new Car("Black", 2024, "Toyota", "Camry", 210);
Bus bus = new Bus("White", 2023, 32);
Vehicle[] vehicles = { car, bus };

foreach (Vehicle vehicle in vehicles)
{
    Console.WriteLine(vehicle.ShowInfo());
}   