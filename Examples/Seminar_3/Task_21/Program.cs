/* Задача 21: Напишите программу, которая принимает на вход координаты двух точек и 
находит расстояние между ними в 2D пространстве.
A (3,6); B (2,1) -> 5,09 
A (7,-5); B (1,-1) -> 7,21      */

double coordinateXa = 3;
double coordinateXb = 2;
double coordinateYa = 6;
double coordinateYb = 1;


double Scalyar = 0;
Scalyar = (Math.Sqrt (Math.Pow(coordinateXa - coordinateXb, 2)  + Math.Pow(coordinateYa-coordinateYb, 2)));
// Лучше найти функция, вычисляющую квадрат
Console.WriteLine(Scalyar);

