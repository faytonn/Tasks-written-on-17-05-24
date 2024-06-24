namespace _20_06_lab
{
    public class Employee
    {
        private static int _id;
        public int ID { get; }
        private string _name;
        public string Name 
        {
            get
            {
                return _name;
            }
            set
            {
                if (NameChecker(value))
                {
                    _name = value;
                }
                
            }
        } 
        public string Surname { get; set; }
        private decimal _salary;
        public decimal Salary 
        {
            get
            {
                return _salary;
            }
            set
            {
                if (SalaryChecker(value))
                {
                    _salary = value;
                }
            }
        }
        private string _position;
        public string Position
        {
            get
            {
                return _position;
            }
            set
            {
                if (PositionChecker(value))
                {
                    _position = value;
                }
            }
        }

        public Employee(string name, string surname, int salary, string position)
        {
            ID = ++_id;
            Name = name;
            Surname = surname;
            Salary = salary;
            Position = position;
        }

        public bool NameChecker(string name)
        {
            if(name.Length < 3)
            {
               return false;
            }
            return true;
        }

        public bool SalaryChecker(decimal salary) 
        {
            if(salary < 0)
            {
                return false;
            }
            return true;
        }

        public bool PositionChecker(string position)
        {
            if(position == "Junior" || position == "Middle" || position == "Senior")
            {
                return true;
            }
            return false;
        }

        public void GetInfo()
        {
            Console.WriteLine($"Name: {Name} \tSurname: {Surname} \tPosition: {Position} \tSalary: {Salary}");
        }
    }
}
