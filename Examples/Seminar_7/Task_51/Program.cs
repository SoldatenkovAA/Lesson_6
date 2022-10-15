/* Задача 51: Задайте двумерный массив. Найдите Сумма элементов главной диагонали.
Например, задан массив: 
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12   */
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
int GetSumElementsOfMainDiagonal(int[,] anyArray)
{
    int sum = 0;
    int i = 0;
    int j = 0; 
    while ( i < anyArray.GetLength(0) && j < anyArray.GetLength(1))
    {
        sum += anyArray[i,j]; 
        i++;
        j++;
    }
    return sum;

}
int[,] startMatrix = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
print2DArray(startMatrix);
int sum = GetSumElementsOfMainDiagonal(startMatrix);
Console.WriteLine($" Сумма элементов главной диагонали равно {sum}");

