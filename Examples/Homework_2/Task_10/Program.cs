/* Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
на выходе показывает вторую цифру этого числа.
456 -> 5;  782 -> 8;  918 -> 1       */

Console.WriteLine("Введите трехзначное число");
int number = Convert.ToInt32(Console.ReadLine());
void checkOnThreeDigitsAndSearchSecondDigit(int anyNumber) 
{
    if(anyNumber > 99 && anyNumber <1000)
    {
        int secondDigit = anyNumber / 10 % 10;
        Console.WriteLine($"Второй цифрой числа {anyNumber} будет цифра {secondDigit}");
    }
    else  
    {
        Console.WriteLine("Вы ввели не трехзначное число, попробуйте еще раз");
    }
}

checkOnThreeDigitsAndSearchSecondDigit(number);