/* Все задачи решаются черещ Рекурсию
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30     */
int GetSumElements(int firstNumber, int secondNumber)
{
    if(secondNumber == firstNumber)
    {
        return secondNumber;
    }
    return secondNumber + GetSumElements(firstNumber, secondNumber - 1);
}
Console.WriteLine("Введите число M");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int secondNumber = Convert.ToInt32(Console.ReadLine());

int sum = GetSumElements(firstNumber,secondNumber);
Console.WriteLine($"Cумма натуральных элементов в промежутке от {firstNumber} до {secondNumber} равна {sum}");
Console.WriteLine();