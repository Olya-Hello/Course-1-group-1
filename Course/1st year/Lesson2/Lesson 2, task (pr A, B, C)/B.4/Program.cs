Console.WriteLine("Хаха! Ничего же вы без меня, Оши, не можете. Ну ладно, так уж и быть. Я продоложу тебе помогать!");

Console.WriteLine("Скажи мне любые два числа, и я скажу какое больше, а какое меньше!");

int number = int.Parse(Console.ReadLine());
int number0 = int.Parse(Console.ReadLine());

if(number <= number0)
{
   Console.WriteLine(number0 + " явно больше чем " + number + "!");
}
else
{
   Console.WriteLine(number + " явно больше чем " + number0 + "!");
}

