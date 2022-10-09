﻿/* Задача 50. Напишите программу, которая на вход принимает позицию элемента в двумерном 
массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4     */

int getNumberFromUser(string userInformation)
{
    int result;
    Console.Write(userInformation);
    string userLine = Console.ReadLine();
    int.TryParse(userLine, out result);
    return result;
}
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
int? getValueFrom2DArrayByPosition(int[,] anyArray, int position)
{
    int width = anyArray.GetLength(1);
    int maxIndex = anyArray.GetLength(0) * width;
    if (maxIndex < position) 
    {
    return null;
    }
    int row = (int)Math.Ceiling((double)position / (double)width) - 1;
    int col = position - (row * width);
    return anyArray[row, col];
}

int[,] generateArray = generate2DArray(3, 4, 1, 9);
print2DArray(generateArray);
int userNumber = getNumberFromUser("Введите позицию элемента (начинаются с нуля) ");
int? number = getValueFrom2DArrayByPosition(generateArray, userNumber);
if (number == null) 
{
Console.WriteLine($"{userNumber} -> такого числа в массиве нет");
}
else  Console.WriteLine($"{userNumber} -> {number}");
