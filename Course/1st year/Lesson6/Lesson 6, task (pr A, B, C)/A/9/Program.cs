Console.WriteLine("Напишите целое число, а мы определим простое ли оно");

bool Number(int number)
{
    bool n = false;
    bool n0 = true;

    for(int i = 2; i < number; i++)
    {
        if(number % i == 0)
        {
           return n;
        }
    }

    return n0;
}

Console.WriteLine(Number(Convert.ToInt32(Console.ReadLine())));
