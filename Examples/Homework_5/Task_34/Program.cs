/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2   */

void printColorTextInConsole(string information, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}
int getLengthOfArrayFromUser()   // юзер задает длину массива(кол-во элементов)
{
    printColorTextInConsole("Введите количество элементов в массиве", ConsoleColor.DarkBlue);
    int arrayLength = Convert.ToInt32(Console.ReadLine());
    return arrayLength;
}
int[] getArrayWithRandomTriplePositiveNumbers(int lengthMassive, int startPoint, int endPoint)  //получаем массив
{
    int[] currentArray = new int[lengthMassive];
    for (int i = 0; i < lengthMassive; i++)
    {
        currentArray[i] = new Random().Next(startPoint, endPoint + 1);
    }
    return currentArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
int getCountEvenNumbersInArray(int[] incomingArray)
{
    int count = 0;
    for (int i = 0; i < incomingArray.Length; i++)
    {
        if(incomingArray[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int lengthMassive = getLengthOfArrayFromUser();
int[] currentMassive = getArrayWithRandomTriplePositiveNumbers(lengthMassive, 100, 999);
printArray(currentMassive);
int countEvenNumbers = getCountEvenNumbersInArray(currentMassive);
printColorTextInConsole($"В данном массиве количество четных чисел {countEvenNumbers} ", ConsoleColor.DarkGreen);



