Console.WriteLine("Привет привет! Сегодня я предлагаю тебе отвлечься от нудных занятий и сыграть со мной в игру!");

Console.WriteLine("Готов начать?");

string word = Console.ReadLine();

Console.WriteLine("Пожалуй я приму это как подтверждение. Угадай число, которое я загадал");

int myNumber = 19;

int yourNumber = Convert.ToInt32(Console.ReadLine());

if(myNumber > yourNumber)

Console.WriteLine("Я думаю твоё число " + yourNumber + " слегка меньше моего!");

else if (myNumber < yourNumber)

Console.WriteLine("Я думаю твоё число " + yourNumber + " слегка больше моего!");

else

Console.WriteLine("Ты угадал? Это невозможно! :(");


int yourNumber0 = Convert.ToInt32(Console.ReadLine());

if(myNumber > yourNumber0)

Console.WriteLine("Я думаю твоё число " + yourNumber0 + " слегка меньше моего! Подсказка, оно двузначное.");

else if (myNumber < yourNumber0)

Console.WriteLine("Я думаю твоё число " + yourNumber0 + " слегка больше моего! Подсказка, оно двузначное.");

else

Console.WriteLine("Ты угадал? Это невозможно! :(");


int yourNumber1 = Convert.ToInt32(Console.ReadLine());

if(myNumber > yourNumber1)

Console.WriteLine("Я думаю твоё число " + yourNumber1 + " слегка меньше моего! Давай, у тебя последняя попытка!");

else if (myNumber < yourNumber1)

Console.WriteLine("Я думаю твоё число " + yourNumber1 + " слегка больше моего! Давай, у тебя последняя попытка!");

else

Console.WriteLine("Ты угадал? Ну наконец-то!^^");


int yourNumber2 = Convert.ToInt32(Console.ReadLine());

if(myNumber > yourNumber2)

Console.WriteLine("Я думаю твоё число " + yourNumber2 + " слегка меньше моего! Эх, ты не угадал(");

else if (myNumber < yourNumber2)

Console.WriteLine("Я думаю твоё число " + yourNumber2 + " слегка больше моего! Эх, ты не угадал(");

else

Console.WriteLine("Ты угадал? Ну наконец-то!^^");
 
