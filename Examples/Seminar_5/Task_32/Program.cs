/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените 
на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]      */

//получим массив

int[] getRandomArray(int length, int startPoint, int endPoint)
{
    int [] resultArray = new int [length];
    for (int i = 0; i < length; i++)
    {
        resultArray[i] = new Random().Next(startPoint, endPoint +1);
    }

    return resultArray;
}
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if(i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.Write("]");
    Console.WriteLine();
}
int[] reverseArray(int [] incomingArray)
{
    //int[] result = new int [incomingArray.Length]; можно с доп.переменной result, можно без нее(тогда на 1 строку меньше)
    for (int i = 0; i < incomingArray.Length; i++)
    {
        //result[i] = - incomingArray[i];
        incomingArray[i] = -incomingArray[i];
    }
    //return result;
    return incomingArray;
}

int [] currentArray = getRandomArray(16, -10, 10);
printArray(currentArray);
int [] returnArray = reverseArray(currentArray);
printArray(returnArray);