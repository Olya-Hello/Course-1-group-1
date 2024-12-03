
Console.WriteLine("Здравствуй!! Давай знакомиться! Меня зовут Оша, а тебя?^^");

string name = Console.ReadLine();

Console.WriteLine("Ух ты, " + name + ", у тебя просто замечательное имя!");

Console.WriteLine("А не подскажешь мне свой год рождения? Чисто в научных интересах!");

int number = 2024;

int years = int.Parse(Console.ReadLine());

   int difference = number - years;

if (years < number)
{
   Console.WriteLine("Тебе " + difference + "? Ну, впринципе всё не так уж и плохо :D");
}
else
{
    Console.WriteLine("Ты кого обмануть пытаешься, хаха! Врунишка.");
    Console.WriteLine("Тебе не может быть " + difference + " лет :/");
}


// можете считать это калькулятором с характером :D