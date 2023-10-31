using ChallengeApp;

Employee employee1 = new Employee("Adam ", "Nowak ", 25);
Employee employee2 = new Employee("Karol ", "Kowalski ", 28);
Employee employee3 = new Employee("Ewa ", "Karolczyk ", 30);

employee1.Addscore(2);
employee1.Addscore(4);
employee1.Addscore(5);
employee1.Addscore(1);
employee1.Addscore(3);

employee2.Addscore(6);
employee2.Addscore(8);
employee2.Addscore(5);
employee2.Addscore(3);
employee2.Addscore(1);

employee3.Addscore(7);
employee3.Addscore(3);
employee3.Addscore(4);
employee3.Addscore(5);
employee3.Addscore(3);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int highestResult = -1;
Employee employeeWithHighestResult = null;

foreach (var employee in employees)
{
    if (employee.Result > highestResult)
    {
        employeeWithHighestResult = employee;
        highestResult = employee.Result;
    }

}
Console.WriteLine("Pracownik z najlepszym wynikiem to:" + 
employeeWithHighestResult.Name
+ employeeWithHighestResult.Surname + employeeWithHighestResult.Age + " lat - Ilość uzyskanych punktów to: " + employeeWithHighestResult.Result);