/* Задача 22: Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4  */

Console.WriteLine("Введите число, для которого необходимо вывести таблицу квадратов ");
double number = Convert.ToInt32(Console.ReadLine());



double square (double number)
{
    double result = 0;
    double count = 1;
    while(count <= number)
    {
        result = Math.Pow(count, 2);
        Console.Write($"{result}  ");
        count = count + 1;
    }
    return result;
}
square(number);
//int answer = square(number);
//Console.WriteLine($"Для числа {number} таблица квадратов следующая: {answer}");
