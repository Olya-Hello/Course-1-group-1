Console.WriteLine("Как тебя зовут?");

string Name(string name, string hello)
{
    return name + hello;
}

Console.WriteLine(Name(Console.ReadLine(), ", Привет!"));

