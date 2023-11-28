var name = "Ew";
var age = 50;
var gender = "Kobieta";




if(gender == "Kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}
else if (gender == "Mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else
{
    Console.WriteLine("Żaden warunek nie został spełniony");
}
