/*
16 Напишите программу, которая принимает на вход два числа и проверяет, 
является ли одно число квадратом другого. 
5, 25 -> да 
-4, 16 -> да 
25, 5 -> да 
8,9 -> нет
сделаю через рандомные числа */

int firstNumber = new Random().Next(1,100);
int secondNumber = new Random().Next(1,100);
Console.WriteLine($"Первое число {firstNumber}, второе {secondNumber}");

void squareChech(int first, int second)
{
    if(firstNumber * firstNumber == secondNumber || secondNumber * secondNumber == firstNumber)
    {
        Console.WriteLine("Одно число является квадратом другого");
    }
    else 
    {
        Console.WriteLine("Числа не являются квадратами друг друга");
    }
}
squareChech(firstNumber, secondNumber);