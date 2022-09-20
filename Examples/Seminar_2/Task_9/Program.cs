/* 
9 Напишите программу, которая выводит случайное число из отрезка [10, 99] 
и показывает наибольшую цифру числа. 78 -> 8 
12-> 2 
85 -> 8   
*/

int getRandomNumberFromRange(int minBorder, int maxBorder)
{
    int result = new int();
    result = new Random().Next(minBorder, maxBorder + 1); 
    return result;
}

int getMaxDigitFromNumber(int number)
{
    int maxDigit = 0;
    while(number > 0)
    {
        int currentDigit = number % 10; 
        if (maxDigit < currentDigit)
        {
            maxDigit = currentDigit;
        }
        number = number / 10;
    }
    return maxDigit;
}
int getMaxDigitFromNumberOfTwoDigit(int number) //более простая версия 
{
    int maxDigit = number % 10; //остаток от деления на 10 
    int secontDigit = number / 10;
    if (maxDigit < secontDigit)
    {
        maxDigit = secontDigit;
    }

    return maxDigit;
}

int randomNumber = getRandomNumberFromRange(10, 99);
Console.WriteLine($"Случайное значение {randomNumber}");    
int maxDigit = getMaxDigitFromNumberOfTwoDigit(randomNumber); 
Console.WriteLine($"Для числа {randomNumber} большая цифра {maxDigit} ");
