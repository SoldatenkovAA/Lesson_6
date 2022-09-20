/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает,
 что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

int randomNumber = new Random().Next(1, 1000000);
Console.WriteLine($"Случайное число {randomNumber}");

int searchThirdDigit (int number)
{
    while (number > 999)
    {
        number = number / 10;
    }
    number = number % 10;
    return number;
}
if (randomNumber > 99)
{
    int thirdDigit = searchThirdDigit(randomNumber);
    Console.WriteLine($"Третья цифра данного числа {thirdDigit}");
}
else 
{
    Console.WriteLine($"У числа {randomNumber} третьей цифры нет");
}