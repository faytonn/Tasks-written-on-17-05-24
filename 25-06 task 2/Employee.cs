namespace _25_06_task_2
{
    public class Employee : IPerson
    {
        public string Name { get; set; }
        public byte Age { get; set; }
        private static int _id;
        public int Id { get; }
        public double Salary { get; set; }

        public Employee(string name, byte age, double salary)
        {
            if (string.IsNullOrEmpty(name) || age <= 0 || salary <= 0)
            {
                throw new ArgumentException("Please provide valid information.");
            }

            Id = ++_id;
            Name = name;
            Age = age;
        }

        public string ShowInfo()
        {
            return $"ID: {Id} \tName: {Name} \tAge: {Age} \tSalary: {Salary}";
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
