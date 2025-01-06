string[] mass = {"шел Штирлиц и упал ","но Упала сбила машина ", "дальше Штрирлиц пошёл один"};

Console.WriteLine("Какой элемент массива вывести? всего три (1, 2, 3)");

int you = int.Parse(Console.ReadLine());

if(you == 1)
{
    Console.WriteLine(mass[0]);
}
else if(you == 2)
{
    Console.WriteLine(mass[1]);
}
else if(you == 3)
{
    Console.WriteLine(mass[2]);
}
else if(you == 4)
{
    Console.WriteLine("введён некорректный номер");
    Console.WriteLine("хаха. на продолжение надеялся? :>");
}
else
{
    Console.WriteLine("введён некорректный номер");
}
