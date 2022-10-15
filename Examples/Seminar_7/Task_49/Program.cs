/* Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.Например, изначально массив выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4   */

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

int [,] startMatrix = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
int[,] MatrixWithQuatreEddElements(int [,] anyArray)
{

    for (int i = 0; i < anyArray.GetLength(0); i++)
    {
        for (int j = 0; j < anyArray.GetLength(1); j++)
        {
            if(i % 2 ==0 && j % 2 == 0)
            {
                anyArray[i, j] = anyArray[i, j] * anyArray[i, j];
            }        
        }
    }
    return anyArray;
}


print2DArray(startMatrix);
int[,] newArray = MatrixWithQuatreEddElements(startMatrix);
Console.WriteLine();
print2DArray(newArray);


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

// тест на бОльшей матрице
int[,] testArray = MatrixWithQuatreEddElements(generate2DArray(10, 10, 1, 9));

Console.WriteLine();
print2DArray(testArray);

