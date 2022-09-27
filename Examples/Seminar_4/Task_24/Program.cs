/*
Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
*/
/*
void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int getSumOfRange(int startPoint, int endPoint)
{
    int result = 0;
    if (startPoint > endPoint)
    {
        printInConsoleWithColor($"Верхняя граница отрицательна {endPoint}",ConsoleColor.DarkYellow);
        int buff = startPoint;
        startPoint = endPoint;
        endPoint = buff;
    }
    for (int i = startPoint; i <= endPoint; i++)
    {
        result += i;
    }
    return result;
}

printInConsoleWithColor("Введите верхнюю границу для суммы ряда",ConsoleColor.DarkMagenta);
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfRage = getSumOfRange(1, userNumber);
Console.WriteLine($"Сумма чисел от 1 до {userNumber} = {sumOfRage}");


Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение 
чисел от 1 до N. (такая же как в 1 задаче, только на плюс на * поменять)
4 -> 24 
5 -> 120
Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями 
и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]


26

Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int CountDigitsInNumber(int userNumber)
{
    int result = 0;
    for ( int i = 1; userNumber != 0; i++)
    {
        userNumber = userNumber / 10;
        result = i;
    }
    return result;
}
Console.WriteLine($"Количество цифр в числе равно {CountDigitsInNumber(userNumber)}");

28 

void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int getMultiplOfRange(int startPoint, int endPoint)
{
    int result = 1;
    if (startPoint > endPoint)
    {
        printInConsoleWithColor($"Верхняя граница отрицательна {endPoint}",ConsoleColor.DarkYellow);
        int buff = startPoint;
        startPoint = endPoint;
        endPoint = buff;
    }
    for (int i = startPoint; i <= endPoint; i++)
    {
        result = result * i;
    }
    return result;
}

printInConsoleWithColor("Введите верхнюю границу для суммы ряда",ConsoleColor.DarkMagenta);
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfRage = getMultiplOfRange(1, userNumber);
Console.WriteLine($"Произведение чисел от 1 до {userNumber} = {sumOfRage}");
*/
int [] array = new int [8];
void RandomDigitInArray(int [] array)
{
    for (int i = 0; i <= 7; i++)
    {
        array[i] = new Random().Next(0,2);
        Console.Write($" {array[i]} ");
    }
    
}
RandomDigitInArray(array);

/*
image.png
/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5*/



Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
userNumber = Math.Abs(userNumber);
int result = 1;
if(userNumber != 0)
{
    result = (int)Math.Log10(userNumber) + 1;
}
Console.WriteLine($"Количество знаков в числе {result}");
