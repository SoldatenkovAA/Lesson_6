/* Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.  */

void checkTriangle(int firstSide, int secondSide, int thirdSide)
{
    int sum13 = firstSide + thirdSide;
    int sum12 = firstSide + secondSide;
    int sum23 = secondSide + thirdSide;

    if(firstSide < sum23 && secondSide < sum13 && thirdSide < sum12)
    {
        Console.WriteLine("Треугольник существует");
    } 
    else
    {
        Console.WriteLine("Треугольника с такими сторонами не существует");
    }
}
checkTriangle(20,3,4);
