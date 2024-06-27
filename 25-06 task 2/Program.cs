using _25_06_task_2;
using _25_06_task_2.Exceptions;

try
{
    Department department1 = new Department("IT", 3);

    Employee employee1 = new Employee("A", 20, 2100);
    Employee employee2 = new Employee("B", 17, 700);
    Employee employee3 = new Employee("C", 18, 2100);
    Employee employee4 = new Employee("C", 18, 2100);

    department1.AddEmployee(employee1);
    department1.AddEmployee(employee2);
    department1.AddEmployee(employee3);
    department1.AddEmployee(employee4);


    Console.WriteLine(employee1.ShowInfo());
    Console.WriteLine(employee2.ShowInfo());
    Console.WriteLine(employee3.ShowInfo());
}
catch(CapacityLimitException)
{
    Console.WriteLine("Limit exceeded.");
}

try
{
    Department department2 = new Department("HR", 2);

    Employee employee1 = new Employee("a", 20, 10000);
    Employee employee2 = new Employee("b", 30, 5750);

    department2.AddEmployee(employee1);
    department2.AddEmployee(employee2);

    Console.WriteLine(department2[0].ShowInfo());
    Console.WriteLine(department2[1].ShowInfo());
    

}
catch(CapacityLimitException)
{
    Console.WriteLine("Limit exceeded");
}
