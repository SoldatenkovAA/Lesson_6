/*
Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон 
возможных координат точек в этой четверти (x и y).
*/
Console.Write("Введите номер четверти:\t");
int userNumber = Convert.ToInt32(Console.ReadLine());
switch (userNumber)
{
    case 1:
    Console.WriteLine("x>0, y>0");
    break;
    case 2:
    Console.WriteLine("x<0, y>0");
    break;
    case 3:
    Console.WriteLine("x<0, y<0");
    break;
    case 4:
    Console.WriteLine("x>0,y<0");
    break;
    default:
    Console.WriteLine($"{userNumber} Не является четвертью");
    break;
}


