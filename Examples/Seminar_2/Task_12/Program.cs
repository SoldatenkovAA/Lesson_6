/*
12 Напишите программу, которая будет принимать на вход два числа и выводить, является ли 
второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления. 
34, 5 -> не кратно, остаток 4 
16, 4 -> кратно
*/
Console.WriteLine("Введите первое число");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число, которое нужно проверить на кратность первому числу");
int secondNumber = Convert.ToInt32(Console.ReadLine());

void multiplicityCheck(int first, int second) //функция проверки на кратность и вывода инф-и
{
    int result = firstNumber % secondNumber;
    if(result == 0)
    {
        Console.WriteLine("Второе число кратно первому");
    }
    else 
    {
        Console.WriteLine($"Второе число не кратно первому, остаток от деления {result}");
    }
}

multiplicityCheck(firstNumber, secondNumber);
