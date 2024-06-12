namespace asbdjasd
{
    public abstract class Vehicle
    {
        public string Color { get; set; }
        public int Year { get; set; }
        public Vehicle(string color, int year)
        {
            Color = color;
            Year = year;
        }

        public abstract string ShowInfo();
        


    }


}
