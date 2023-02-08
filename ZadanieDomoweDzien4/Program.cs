var name = "Ewa";
string gender = "Kobieta";
string gender2 = "Mężczyzna";
int Age = 28;
int Age2 = 33;
int Age3 = 17;

if (gender == "Kobieta" && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
if (name == "Ewa" && Age2 == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
if (name == "Ewa")
    if (Age < 33)
    {
        Console.WriteLine("Ewa, poniżej 33 lat");
    }
if (gender2 == "Mężczyzna" && Age3 < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
if (gender2 == "Mężczyzna" && Age2 >= 18)
{
    Console.WriteLine("Pełnoletni Mężczyzna");
}
if (gender2 != gender && Age >= 18)
{
    Console.WriteLine("Jest to pełnoletnia kobieta");
}
else
{
    Console.WriteLine("Jestem kimś innym");
}
