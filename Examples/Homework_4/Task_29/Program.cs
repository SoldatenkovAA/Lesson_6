/* Задача 29: Напишите программу, в которой пользователь задает длину массива, 
элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]     */  

void printColorText(string information, ConsoleColor color)    // функция добавления цвета в шрифт
{
    Console.ForegroundColor = color;
    Console.Write(information);
    Console.ResetColor();
}

printColorText("Введите длину массива:  ", ConsoleColor.DarkGreen);
int lengthMassive = Convert.ToInt32(Console.ReadLine());

int [] array = new int [lengthMassive];

void randomDigitInArray(int [] array)  //функция заполнения рандомного заполнения массива в диапазоне [1,99]
{
    int i = 0;
    for(i = 0; i < lengthMassive - 1; i++)
    {
        array[i] = new Random().Next(1, 100);
        printColorText($"{array[i]}, ", ConsoleColor.DarkCyan);
    }
    array[i] = new Random().Next(1, 100);
    printColorText($"{array[i]}", ConsoleColor.DarkCyan);
}

printColorText("[", ConsoleColor.DarkMagenta);
randomDigitInArray(array);
printColorText("]", ConsoleColor.DarkMagenta);
Console.WriteLine();