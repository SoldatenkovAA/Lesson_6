/* Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36   */
void printInConsoleWithColor(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int getSumOfRange(int startPoint, int endPoint)
{
    int result = 0;
    if( startPoint > endPoint)
    {
        printInConsoleWithColor($"Верхняя граница отрицательна {endPoint}", ConsoleColor.DarkYellow);
        int buff = startPoint;   // меняем местами, если вводим в условии отрицательное число
        startPoint = endPoint;
        endPoint = buff;
    }
    for(int i = startPoint; i <= endPoint; i++)
    {
        result += i;
    }
    return result;
}
printInConsoleWithColor("Введите верхнюю границу для суммы ряда", ConsoleColor.DarkMagenta);
int userNumber = Convert.ToInt32(Console.ReadLine());
int sumOfRage = getSumOfRange(1, userNumber);
Console.WriteLine($"Сумма чисел от 1 до {userNumber} = {sumOfRage}");