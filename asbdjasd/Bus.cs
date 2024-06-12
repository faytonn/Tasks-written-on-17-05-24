namespace asbdjasd
{
    public class Bus : Vehicle
    {
        public int PassengerCount { get; set; }

        public Bus(string color, int year, int passengerCount) :base(color, year)
        {
            PassengerCount = passengerCount;
        }

        public override string ShowInfo(string color, int year)
        {
            return $"Color: {color} \nYear: {year} \nPassenger count: {PassengerCount} ";
        }
    }
}
