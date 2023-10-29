string name = "Ewa";
var gender = "kobieta";
int age = 33;

if (age == 33 && name == "Ewa")
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 30 && gender == "kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (age < 18 && gender != "kobieta")
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}