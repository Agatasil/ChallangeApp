string name = "Ewa";
string sex = "kobieta";
var age = 50;

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniezej 30 lat");
}
else if (sex == "kobieta" && name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (sex == "mezczyzna" && age < 18)
{
    Console.WriteLine("niepelnoletni mezczyzna");
}
else if (sex == "mezczyzna" && age >= 18)
{
    Console.WriteLine("pelnoletni mezczyzna");
}
else
{
    Console.WriteLine("Inna kobieta");
}