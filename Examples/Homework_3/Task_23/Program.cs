/*   Задача 23. Напишите программу, которая принимает на вход число (N) и 
выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125   */

Console.WriteLine("Введите число, для которого необходимо вывести таблицу кубов от 1 до этого числа ");
double number = Convert.ToInt32(Console.ReadLine());

double square (double number)
{
    double result = 0;
    double count = 1;
    while(count <= number)
    {
        result = Math.Pow(count, 3);
        Console.Write($"{result}  ");
        count = count + 1;
    }
    return result;
}
square(number);



