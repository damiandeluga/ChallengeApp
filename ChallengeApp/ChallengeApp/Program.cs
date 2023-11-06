using ChallengeApp;

var employee1 = new Employee("Adam", "Kowalski");

employee1.AddGrade(2);
employee1.AddGrade(2);
employee1.AddGrade(6);
var statistics = employee1.GetStatistics();
var statistics1 = employee1.GetStatisticsWithDoWhile();
var statistics2 = employee1.GetStatisticsWithFor();
var statistics3 = employee1.GetStatisticsWithWhile();
var statistics4 = employee1.GetStatisticsWithForEach();

Console.WriteLine("Wyniki ocen pracowniczych dla metody GetStistics");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Average: {statistics.Min:N2}");

Console.WriteLine("Wyniki ocen pracowniczych dla metody GetStisticsWithForEach");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");
Console.WriteLine($"Average: {statistics1.Min:N2}");

Console.WriteLine("Wyniki ocen pracowniczych dla metody GetStisticsWithDoWhile");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Average: {statistics2.Min:N2}");

Console.WriteLine("Wyniki ocen pracowniczych dla metody GetStisticsWithFor");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");
Console.WriteLine($"Average: {statistics3.Min:N2}");

Console.WriteLine("Wyniki ocen pracowniczych dla metody GetStisticsWithWhile");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
Console.WriteLine($"Average: {statistics4.Min:N2}");