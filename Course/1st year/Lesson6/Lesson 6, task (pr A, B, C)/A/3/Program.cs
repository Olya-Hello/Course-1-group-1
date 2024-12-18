Console.WriteLine("Напиши два числа, и получи большее из них");

int Numbers(int number, int number0)
{
    if(number > number0)
    {
        return number; 
    }
    else if(number < number0)
    {
        return number0;
    }
    else
    {
        return number;
    }
}

Console.WriteLine(Numbers(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())));

