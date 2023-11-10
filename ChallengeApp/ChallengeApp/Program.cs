using ChallengeApp;

Console.WriteLine("Witamy w programie WorkerGrade");
Console.WriteLine("--------------------------------");
Console.WriteLine();
Console.WriteLine("Aby zobaczy� ko�cow� ocen�, prosz� nacisn�� q");
Console.WriteLine();

var employee = new EmployeeInFile("Damian", "Kowalski");
employee.GradeAdded += Employee_GradeAdded;
void Employee_GradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("Dodano now� ocen�");
}

while (true)
{
    Console.WriteLine("Prosz� poda� ocen� pracownika");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Wykryto wyj�tek: {ex.Message}");
    }

}
var statistics = employee.GetStatistics();
Console.WriteLine($"MAX: {statistics.Max}");
Console.WriteLine($"MIN: {statistics.Min}");
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"GRADE: {statistics.AverageLetter}");




