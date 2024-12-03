Console.WriteLine("Привет! Напиши мне любое трёхзначное число, а я выведу тебе его разряды.");

int number = Convert.ToInt32(Console.ReadLine()); // 324
  
int sto = 100;

int sto1 = 10;

int number0 = number / sto; // 3

int number4 = number0 * sto;  //300

int number5 = number - number4;  //24

int number1 = number5 / sto1;  // 2

int number6 = number1 * sto1;  // 20

int number2 = number5 - number6;  // 4


Console.WriteLine("В твоём числе " + number + ": " + number0 + " сотен, " + number1 + " десятков, " + number2 + " едениц.");
