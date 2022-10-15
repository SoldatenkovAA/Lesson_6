﻿/* Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится 
по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5   */
int[,] Generate2DMatrixMNsum(int row, int column)
{
    int[,] twoDArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            twoDArray[i, j] = i + j;
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

int [,] generateArray = Generate2DMatrixMNsum(3, 4);
print2DArray(generateArray);