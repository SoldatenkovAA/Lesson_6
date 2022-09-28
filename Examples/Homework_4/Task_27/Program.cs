/*   Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12      */
void printColorText(string information, ConsoleColor color)    // функция добавления цвета в шрифт
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}

int getSumOfDigits(int number) //функция нахождения суммы цифр в числе
{
    int result = 0;
    while(number > 0)
    {
        result = result + number % 10;
        number = number / 10;
    }
    return result;
}

printColorText("Введите число для нахождения суммы цифр в нем", ConsoleColor.DarkMagenta);
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

int result = getSumOfDigits(number);
printColorText($"Сумма цифр в числе {number} будет равна {result}", ConsoleColor.DarkGreen);












