Console.WriteLine("Введите температуру");

double Temper(int temper, double number, int number0)
{
    return temper * number + number0;
}

Console.WriteLine(Temper(Convert.ToInt32(Console.ReadLine()), 1.8, 32));

