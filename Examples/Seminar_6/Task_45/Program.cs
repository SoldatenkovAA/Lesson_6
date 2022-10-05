/* Задача 45: Напишите программу, 
которая будет создавать копию заданного массива с помощью поэлементного копирования.  */

int getLengthArrayFromUser()  
{
    Console.WriteLine("Введите длину массива");
    int length = Convert.ToInt32(Console.ReadLine());
    return length;
}

int[] getArray(int length, int start, int end)
{
    int[] newArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        newArray[i] = new Random().Next(start, end + 1);
    }
    return newArray;
}

void printArray(int[] anyArray, string name)
{
    Console.WriteLine($"----------{name}----------");
    Console.Write("[");
    for (int i = 0; i < anyArray.Length; i++)
    {
        Console.Write(anyArray[i]);
        if (i < anyArray.Length - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

int[] copyArray(int[] anyArray)
{
    int[] newArray = new int[anyArray.Length];
    for (int i = 0; i < anyArray.Length; i++)
    {
        newArray[i] = anyArray[i];
    }
    return newArray;
}




int length = getLengthArrayFromUser();
int[] ourArray = getArray(length, 1, 99);
printArray(ourArray, "Our array");

int[] copArray = copyArray(ourArray);
Console.WriteLine();
printArray(copArray, "Copy array");