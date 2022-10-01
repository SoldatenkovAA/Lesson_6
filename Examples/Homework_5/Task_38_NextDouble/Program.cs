/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76     */
void printColorTextInConsole(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
double[] getArrayOfNumbersWithTwoDigitsAfterPoint(int length)
{
    double[] newArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        newArray[i] = Math.Round(new Random().NextDouble() * 100, 2);
    }
    return newArray;
}
void printArray(double[] anyArray)
{
    Console.Write("[");
    for (int i = 0; i < anyArray.Length; i++)
    {
        Console.Write(anyArray[i]);
        if(i < anyArray.Length - 1)
        {
            Console.Write("  ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
double differenceBetweenMaxAndMinInArray(double[] incomingArray)
{
    double max = incomingArray[0];
    double min = incomingArray[0];
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i] > max)
        {
            max = incomingArray[i];
        }
        else if(incomingArray[i] < min)
        {
            min = incomingArray[i];
        }
    }
    return Math.Round((max - min), 2);
}

double[] currentArray = getArrayOfNumbersWithTwoDigitsAfterPoint(10);
printArray(currentArray);
double differenceMaxAndMin = differenceBetweenMaxAndMinInArray(currentArray);
printColorTextInConsole($"Разница между максимальным и минимальным элементами массива составляет {differenceMaxAndMin}", ConsoleColor.DarkBlue);


