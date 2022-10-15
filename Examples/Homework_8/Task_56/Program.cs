/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка  */
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

int[] GetArrayWithSumsOfRowsFrom2DArray(int[,] inputArray)
{
    int [] arrayWithSumsOfRows = new int [inputArray.GetLength(0)];
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            sum += inputArray[i, j];
        }
        arrayWithSumsOfRows[i] = sum;

    }
    return arrayWithSumsOfRows;
}
void printArray(int[] anyArray)
{
    Console.Write("[");
    for (int i = 0; i < anyArray.Length; i++)
    {
        Console.Write(anyArray[i]);
        if(i < anyArray.Length - 1)
        {
            Console.Write(", ");
        }
    }   
    Console.Write("]");
    Console.WriteLine();
}
int getMinInArray(int [] anyArray)
{
    int min = anyArray[0];
    int row = 0;
    for (int i = 1; i < anyArray.Length; i++)
    {
        if(anyArray[i] < min)
        {
            min = anyArray[i];
            row = i;
        }
    }
    return row + 1;
}
int[,] startArray = GenerateArray(5, 5, 0, 9);
ShowArray(startArray);
int[] arraySumsOfRows = GetArrayWithSumsOfRowsFrom2DArray(startArray);
Console.Write("Суммы элементов в каждой строке:");
printArray(arraySumsOfRows);
Console.WriteLine($"{getMinInArray(arraySumsOfRows)} строка с наименьшей суммой элементов");
