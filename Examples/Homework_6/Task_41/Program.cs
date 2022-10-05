/*  Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3      */

int getCountOfPositiveNumbers(string numbers)
{
    int count = 0;
    string temp = string.Empty;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] != ',')  
        {
            temp += numbers[i];  
        } 
        else
        {
            if (Convert.ToInt32(temp) > 0) 
            {
                count++;
            }
            temp = string.Empty;  
        }
    }
    if (Convert.ToInt32(temp) > 0) 
    {
        count++;   
    }
    return count;
}

Console.Write("Введите числа через запятую: ");
string userNumbers = Console.ReadLine();
int result = getCountOfPositiveNumbers(userNumbers);
Console.WriteLine($"Количество чисел больше нуля равно {result} ");

