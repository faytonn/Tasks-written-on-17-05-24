using _25_06_task_2.Exceptions;
namespace _25_06_task_2
{
    public class Department
    {
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        private Employee[] Employees;
        public Department(string name, int employeeLimit)
        {
            Name = name;
            EmployeeLimit = employeeLimit;
            Employees = new Employee[0];
        }

        public void AddEmployee(Employee employee)
        {
            if (Employees.Length > EmployeeLimit)
            {
                throw new CapacityLimitException();
            }

            Array.Resize(ref Employees, Employees.Length + 1);
            Employees[Employees.Length - 1] = employee;
        }

        public Employee this[int i]
        {
            get
            {
                return Employees[i];
            }
            set
            {
                Employees[i] = value;
            }
        }
    }
}
