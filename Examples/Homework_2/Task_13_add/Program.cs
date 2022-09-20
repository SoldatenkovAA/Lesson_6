// вариант с отрицательными числами
int randomNumber = new Random().Next(-1000000, 1000000);
Console.WriteLine($"Случайное число {randomNumber}");

if(randomNumber < 0)
{
    randomNumber = - randomNumber;
}

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