/* Задача 39: Напишите программу, которая перевернёт одномерный массив 
(последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]   */


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
int[] getReverseArray (int[] anyArray)
{
    int[] newReverseArray = new int[anyArray.Length];
    for (int i = 0; i < anyArray.Length; i++)
    {
        newReverseArray[i] = anyArray[anyArray.Length - 1 - i];
    }
    return newReverseArray;
}


int length = getLengthArrayFromUser();
int[] firstArray = getArray(length, 1, 99);
printArray(firstArray, "Основной массив");
Console.WriteLine();

int[] reverseArray = getReverseArray(firstArray);
printArray(reverseArray, "Перевернутый массив");
Console.WriteLine();
