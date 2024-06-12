namespace asbdjasd
{
    public  class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public Car(string color, int year, string brand, string model, int maxSpeed) :base(color, year) 
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
            
        }

        public override string ShowInfo(string color, int year)
        {
            return $"Color: {color} \nYear: {year} \nBrand: {Brand} \nModel: {Model} \nMax Speed: {MaxSpeed}";
        }
    }
}
