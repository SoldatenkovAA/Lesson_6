/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)        */
// x = (b2 - b1) / (k1 - k2)

double getXY(double b1, double k1, double b2, double k2, double deviation) //deviation == 0 выводим Х, ==1 выводим Y
{
    double x = (b2 - b1) / (k1 - k2);
    if(deviation == 0) 
    {
        return x;
    }
    else
    {
        double y = k1 * x + b1;
        return y;
    }
}
int getNumberFromUser(string userInformation)
{
    int result;
    Console.Write(userInformation);
    string userLine = Console.ReadLine();
    int.TryParse(userLine, out result);
    return result;
}

int b1 = getNumberFromUser("b1: ");
int k1 = getNumberFromUser("k1: ");
int b2 = getNumberFromUser("b2: ");
int k2 = getNumberFromUser("k2: ");

double x = getXY(b1, k1, b2, k2, 0);
double y = getXY(b1, k1, b2, k2, 1);
Console.WriteLine($"Точка пересечения этих прямых имеет координаты ({x}; {y})");


