using task2_20_06;

bool systemProcess = true;

while (systemProcess)
{
    Car car = new Car();

    Console.WriteLine("How much fuel do you have at the moment?");
    double fuel = int.Parse(Console.ReadLine());

    Console.WriteLine("How many litres is the tank capacity in your car?");
    double tankCapacity = int.Parse(Console.ReadLine());
    
    restart:
    Console.WriteLine("What is your car's fuel consumption (The standard is per 100km)");
    double fuelConsumption = int.Parse(Console.ReadLine());

    Console.WriteLine(">>>MENU<<<");
    Console.WriteLine("commands:");
    Console.WriteLine("[1] Drive");
    Console.WriteLine("[2] Go to fuel station");
    Console.WriteLine("[3] Show fuel");
    Console.WriteLine("[4] Show the distance driven");

    int command = int.Parse(Console.ReadLine());
    Console.Clear();

    switch (command)
    {
        case 1:
            Console.WriteLine("How many kilometers do you want to drive?");
            double kilometer = int.Parse(Console.ReadLine());

            Console.WriteLine(car.Drive(kilometer));
            break;
        case 2:
            Console.WriteLine("How many liters do you want to refuel?");
            double amount = int.Parse(Console.ReadLine());

            Console.WriteLine(car.Refuel(amount));
            break;
        case 3:
            Console.WriteLine(car.ShowFuel);
            break;
        case 4:
            Console.WriteLine(car.ShowMileage);
            break;
        case 5:
            systemProcess = false;
            return;
        default:
            Console.WriteLine("Please enter a valid value");
            break;

    }
     goto restart;







}