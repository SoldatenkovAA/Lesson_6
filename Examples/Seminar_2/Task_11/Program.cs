/*
11 Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
 456 -> 46 
 782 -> 72 
 918 -> 98
*/

int randomNumberThreeDigits = new Random().Next(100, 1000);
Console.WriteLine($"Случайное трехзначное число {randomNumberThreeDigits}");

int fromThreeDigitsDoTwoDigits(int number)  //делаю функцию для решения задачи 
{
    int firstDigit = number / 100;
    int secondDigit = number % 10;
    int newNumber = firstDigit * 10 + secondDigit;
    return newNumber;
}
int answer = fromThreeDigitsDoTwoDigits(randomNumberThreeDigits);
Console.WriteLine($"Новым числом будет число {answer}");
