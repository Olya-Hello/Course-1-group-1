Console.WriteLine("Напиши число, а мы скажем четное оно или нет");

bool Number (int number)
{
    bool name = true;
    bool name0 = false;

    if(number %2 == 0)
    {
        return name;
    }
    else
    {
        return name0;
    }
}

Console.WriteLine(Number(Convert.ToInt32(Console.ReadLine())));