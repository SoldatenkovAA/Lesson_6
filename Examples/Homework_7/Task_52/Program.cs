/*   Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.    */

int[,] generate2DArray(int height, int width, int randomStart, int randomEnd)
{
    int[,] twoDArray = new int[height, width];
    for (int i = 0; i < height; i++)
    {
        for (int j = 0; j < width; j++)
        {
            twoDArray[i, j] = new Random().Next(randomStart, randomEnd + 1);
        }
    }
    return twoDArray;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}

void print2DArray(int[,] arrayToPrint)
{
    Console.Write("\t");
    for (int i = 0; i < arrayToPrint.GetLength(1); i++)
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

double[] getAverageFromColumns(int[,] anyArray)
{
    double[] averageSum = new double[anyArray.GetLength(1)];
    for (int col = 0; col < anyArray.GetLength(1); col++)
    {
        int sum = 0;
        for (int row = 0; row < anyArray.GetLength(0); row++)
        {
            sum += anyArray[row, col];
        }
        averageSum[col] = Math.Round((double)sum / (double)anyArray.GetLength(0), 1);
    }
    return averageSum;
}
void PrintArray(double[] array)
{
    Console.Write($"{array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"; {array[i]}");
    }
    Console.WriteLine(".");
}

int[,] generateArray = generate2DArray(3, 4, 1, 9);
print2DArray(generateArray);
double[] averageSums = getAverageFromColumns(generateArray);
Console.Write("Среднее арифметическое каждого столбца: ");
PrintArray(averageSums);
