/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0    */
void printColorTextInConsole(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int[] getArray(int length, int firstPoint, int lastPoint)
{
    int[] newArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        newArray[i] = new Random().Next(firstPoint, lastPoint + 1);
    }
    return newArray;
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
int getSumNumbersWithOddIndexes(int[] anyArray)
{
    int sum = 0;
    for (int i = 1; i < anyArray.Length; i+=2)
    {
        sum += anyArray[i];
    }
    return sum;
}

int [] ourArray = getArray(6, -20, 20);
printArray(ourArray);
int sumNumbersWithOddIndexes = getSumNumbersWithOddIndexes(ourArray);
printColorTextInConsole($"Сумма элементов массива с нечетными индексами равна {sumNumbersWithOddIndexes}", ConsoleColor.Blue);
