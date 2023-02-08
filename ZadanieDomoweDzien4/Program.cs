var name = "Ewa";
bool Woman = true;
int Age = 17;
int Age2 = 33;

if (Woman == true && Age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && Age2 == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (name == "Ewa" && Age < 33)
{
    Console.WriteLine("Ewa, poniżej 33 lat");
}
else if (Woman == false && Age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (Woman == false && Age2 >= 18)
{
    Console.WriteLine("Pełnoletni Mężczyzna");
}
else if (Woman == true && Age2 >= 18)
{
    Console.WriteLine("Jest to pełnoletnia kobieta");
}
else
{
    Console.WriteLine("Jest to ktoś inny");
}
