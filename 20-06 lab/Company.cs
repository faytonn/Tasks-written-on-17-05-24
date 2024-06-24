namespace _20_06_lab
{
    public class Company
    {
        private static int _id;
        public int ID{ get; set; }
        public string Name { get; set; }
        private Employee[] Employees;

        public Company(string name)
        {
            Name = name;
            Employees = new Employee[0];
        }

        public void Add(Employee employee)
        {
            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[^1]= employee;
            Console.WriteLine("...Added!");
        }

        public void GetAllEmployees(string name, string position)
        {
            foreach(Employee emp in Employees)
            {
                emp.GetInfo();
            }
        }

        public void GetEmployeesByPosition(string position)
        {
            foreach(Employee emp in Employees)
            {
                if(emp.Position == position)
                {
                    emp.GetInfo();
                }
            }
        }

        public void GetEmployeesBySalaryRange(decimal min, decimal max)
        {
            foreach(var emp in Employees)
            {
                if (emp.Salary >= min && emp.Salary <= max);
            }
        }

        public void RemoveEmployee(int ID)
        {
            for(int i = 0; i < Employees.Length; i++)
            {
                if (Employees[i].ID == ID)
                {
                    for (int j = i; j < Employees.Length - 1; j++) 
                    {
                        Employees[j] = Employees[j + 1];
                    }

                    Array.Resize(ref Employees, Employees.Length - 1);
                }
            }
        }



    }
}
