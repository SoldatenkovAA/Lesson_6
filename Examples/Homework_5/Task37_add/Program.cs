/* Задача 37(сложная необязательная): Найдите произведение пар чисел в одномерном массиве. 
Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21  */

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
int[] getNewArrayFromEvenArray(int[] anyArray) //для четного
{
    int[] newArray = new int[anyArray.Length/2];
    for (int i = 0; i < anyArray.Length/2; i++)
    {
        newArray[i] = anyArray[i] * anyArray[anyArray.Length -1 - i];
    }
    return newArray;    
}
int[] getNewArrayFromOddArray(int[] anyArray) //для нечетного
{

    int[] newArray = new int[anyArray.Length/2 + 1];
    for (int i = 0; i < anyArray.Length/2; i++)
    {
        newArray[i] = anyArray[i] * anyArray[anyArray.Length -1 - i];
    }
    newArray[anyArray.Length/2] = anyArray[anyArray.Length/2];
    return newArray;    
}

Console.WriteLine("Введите длину массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] firstArray = getArray(length, 1, 10);
printArray(firstArray);

if(firstArray.Length % 2 == 0)
{
    int [] ArrayFromEvenArray = getNewArrayFromEvenArray(firstArray);
    printArray(ArrayFromEvenArray);
}
else
{
    int [] ArrayFromOddArray = getNewArrayFromOddArray(firstArray);
    printArray(ArrayFromOddArray);
}