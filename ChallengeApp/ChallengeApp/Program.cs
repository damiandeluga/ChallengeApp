using ChallengeApp;

var employee1 = new Employee("Adam", "Kowalski");

employee1.AddGrade(2);
employee1.AddGrade(2);
employee1.AddGrade(6);

var statistics = employee1.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}"); 

