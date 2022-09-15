/*Напишите программу, которая на вход принимает два числа и проверяет, 
является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет */

Console.WriteLine("Введите значение первого числа ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение второго числа ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber == secondNumber * secondNumber)
{
    Console.WriteLine ("Первое число является квадратом второго");
}

else 
{
    Console.WriteLine ("Первое число не является квадратом второго");
}  

 
