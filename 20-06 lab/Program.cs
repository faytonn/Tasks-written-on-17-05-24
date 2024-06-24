using _20_06_lab;

Employee employee1 = new("Gunel", "Qehremani", 3500, "Senior");
Employee employee2 = new("Aysun", "Eminli", 3500, "Senior");
Employee employee3 = new("Fatima", "Valiyeva", 700, "Junior");
Employee employee4 = new("Asiman", "Gasimzada", 5000, "Senior");
Employee employee5 = new("Adil", "Valiyev", 700, "Junior");

Company company = new("Code Academy");

company.Add(employee1);
company.Add(employee2);

company.GetEmployeesByPosition("Junior");

company.GetAllEmployees();
