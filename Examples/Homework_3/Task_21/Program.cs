/*  Задача 21. Напишите программу, которая принимает на вход координаты двух точек и
 находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53    */

int getCoordinateFromUser(string userInformation)
{
    int result = 0;
    Console.Write(userInformation);
    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.Write($"Необходимо ввести целое число, введите еще раз {userInformation} ");
    }
    return result;
}

double distanceBetweenTwoPointsIn3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
}

// координаты точки А (x1, y1, z1) и точки В(х2, y2, z2)

int x1 = getCoordinateFromUser("x1 = ");
int y1 = getCoordinateFromUser("y1 = ");
int z1 = getCoordinateFromUser("z1 = ");
int x2 = getCoordinateFromUser("x2 = ");
int y2 = getCoordinateFromUser("y2 = ");
int z2 = getCoordinateFromUser("z2 = ");

double distance = distanceBetweenTwoPointsIn3D (x1, y1, z1, x2, y2, z2);
Console.WriteLine($"Расстояние между точками А({x1}, {y1}, {z1}) и В({x2}, {y2}, {z2}) составит {distance}"); 

