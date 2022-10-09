/* Задача 47. Задайте двумерный массив размером m×n, 
заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9     */

int getNumberFromUser(string userInformation)
{
    int result;
    Console.Write(userInformation);
    string userLine = Console.ReadLine();
    int.TryParse(userLine, out result);
    return result;
}
double[,] generate2DArray(int height, int width, int startPoint, int endPoint) 
{
    double[,] twoDArray = new double[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = (double)(new Random().Next(startPoint * 10, endPoint * 10 + 1)) / 10; 
        }
    } 
    return twoDArray;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.Write(data);
    Console.ResetColor();
}
void print2DArray(double[,] arrayToPrint)
{
    Console.Write("\t");
    for (double i = 0; i < arrayToPrint.GetLength(1); i++)
    {
        printColorData(i + "\t");
    }
    Console.WriteLine();
    for (int i = 0; i < arrayToPrint.GetLength(0); i++)
    {
        printColorData(i + "\t");
        for (int j = 0; j < arrayToPrint.GetLength(1); j++)
        {
            Console.Write(arrayToPrint[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int height = getNumberFromUser("Введите количество строк m: ");
int width = getNumberFromUser("Введите количество  столбцов n: ");
Console.WriteLine();
double[,] generateArray = generate2DArray(height, width, -10, 10);  
print2DArray(generateArray);
Console.WriteLine();