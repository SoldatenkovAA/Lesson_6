/* Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3  */
/*
Console.WriteLine("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > max)
{
    max = secondNumber;
    Console.WriteLine($"Большее число - второе ({secondNumber}), а меньшее - первое ({firstNumber})");
}
else 
{
    Console.WriteLine($"Большее число - первое ({firstNumber}), а меньшее - второе ({secondNumber})");
}    сверху рабочее решение, попробую еще ситуацию с равными числами приделать, код внизу*/

Console.WriteLine("Введите первое число ");
int firstNumber = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число ");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int max = firstNumber;

if (secondNumber > max)
{
    max = secondNumber;
    Console.WriteLine($"Большее число - второе ({secondNumber}), а меньшее - первое ({firstNumber})");
}
else 
{
    if(firstNumber > secondNumber)
    {
        Console.WriteLine($"Большее число - первое ({firstNumber}), а меньшее - второе ({secondNumber})");
    }
    if(firstNumber==secondNumber)
    {
        Console.WriteLine("Весьма остроумно! Вы ввели два одинаковых числа :)");
    }
}