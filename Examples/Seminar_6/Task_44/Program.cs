/* Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
Первые два числа Фибоначчи: 0 и 1.
Если N = 5 -> 0 1 1 2 3
Если N = 3 -> 0 1 1
Если N = 7 -> 0 1 1 2 3 5 8  */

void PrintInConsoleWithColor(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.Write(message);
    Console.ResetColor();
}

int GetNumberFromUser(string userInformation)
{
    int result;
    PrintInConsoleWithColor($"{userInformation}: ", ConsoleColor.DarkBlue);
    while (!int.TryParse(Console.ReadLine(), out result) || result <= 0)
    {
        PrintInConsoleWithColor($"Ошибка ввода! Ожидается число больше нуля. {userInformation}: ", ConsoleColor.DarkYellow); ;
    }
    return result;
}

int[] fibonacci(int length)
{
    int[] fiboArray = new int[length];
    fiboArray[0] = 0;
    fiboArray[1] = 1;
    for (int i = 2; i < length; i++)
    {
        fiboArray[i] = fiboArray[i - 1] + fiboArray[i -2];
    }
    return fiboArray;
}

void printFibo (int[] anyArray)
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
/*
void printFibo (int[] anyArray)    
{
    Console.Write($"[{anyArray[0]}");                   //альтернатива вывода массива
    for (int i = 1; i < anyArray.Length; i++)
    {
        Console.Write($", {anyArray[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}*/

int length = GetNumberFromUser("Введите количество чисел Фибоначчи");
int[] newArray = fibonacci(length);
printFibo(newArray);
