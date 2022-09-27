/*  Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]       */

int [] array = new int [8];
void RandomDigitInArray(int [] array)
{
    int i = 0;
    for( i = 0; i < 7; i++)
    {
        array[i] = new Random().Next(0, 2);
        Console.Write($" {array[i]}, ");
    }
    array[i] = new Random().Next(0, 2);
    Console.Write($" {array[i]} ");
}
Console.Write("[");
RandomDigitInArray(array);
Console.Write("]");