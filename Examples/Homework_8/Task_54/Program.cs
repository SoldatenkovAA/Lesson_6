/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки 
двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2         */
int[,] GenerateArray(int hight, int weight, int startPoint, int endPoint)
{
    int[,] generatedArray = new int[hight, weight];
    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < weight; j++)
        {
            generatedArray[i, j] = new Random().Next(startPoint, endPoint + 1);
        }
    }
    return generatedArray;
}
void printColorData(string data)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.Write(data);
    Console.ResetColor();
}
void ShowArray<T>(T[,] inputArray)
{
    printColorData($" \t");
    for (int i = 0; i < inputArray.GetLength(1); i++)
    {
        printColorData($"{i}\t");
    }
    Console.WriteLine();
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        printColorData($"{i}\t");
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write($"{inputArray[i, j].ToString()}\t");
        }
        Console.WriteLine();
    }
}
int[,] GetRowsFromMaxToMinInArray(int[,] inputArray)  
{
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int k = 0; k < inputArray.GetLength(1) - 1; k++)
        {
            for (int j = 0; j < inputArray.GetLength(1) - 1; j++)
            {
                if (inputArray[i, j + 1] > inputArray[i, j])
                {
                    int buffer = inputArray[i, j];
                    inputArray[i, j] = inputArray[i, j + 1];
                    inputArray[i, j + 1] = buffer;
                }
            }
        }
    }
    return inputArray;
}
int[,] startArray = GenerateArray(5, 5, 0, 9);
ShowArray(startArray);
Console.WriteLine();
int[,] arrayWithRowsFromMAxToMin = GetRowsFromMaxToMinInArray(startArray);
ShowArray(arrayWithRowsFromMAxToMin);



