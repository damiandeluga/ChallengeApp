using ChallengeApp;


Console.WriteLine("Witamy w programie WorkerGrade");
Console.WriteLine("--------------------------------");
Console.WriteLine();
Console.WriteLine("Aby zobaczyæ koñcow¹ ocenê, proszê nacisn¹æ q");
Console.WriteLine();

var employee = new Employee("Damian","Kowalski");


while(true)
{
    Console.WriteLine("Proszê podaæ ocenê pracownika");
   
    var input = Console.ReadLine();
    if (input =="q")
    {
        break;
    }
    employee.AddGrade(input);

}


var statistics = employee.GetStatistics();
Console.WriteLine($"MAX: {statistics.Max}");
Console.WriteLine($"MIN: {statistics.Min}");
Console.WriteLine($"AVG: {statistics.Average}");
Console.WriteLine($"GRADE: {statistics.AverageLetter}");



