/*  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16      */

int userNumber; // число для возведения в степень
int userDegree; // степень

void printInConsoleWithColor(string information, ConsoleColor color)    // функция добавления цвета в шрифт
{
    Console.ForegroundColor = color;
    Console.WriteLine(information);
    Console.ResetColor();
}

int getUserNumberAndDegree()   //функция для получения числа и степени от пользователя
{
    printInConsoleWithColor("Введите число, которое нужно возвести в степень", ConsoleColor.Blue);
    userNumber = Convert.ToInt32(Console.ReadLine());
    printInConsoleWithColor("Введите степень, в которую мы возведем число", ConsoleColor.Blue);
    userDegree = Convert.ToInt32(Console.ReadLine());
    
    return userNumber;
    return userDegree; 
}

int getResultFromDegreeOfNumber(int userNumber, int userDegree)  // функция для возведения числа в степень
{
    int result = 1;
    for(int i = 1; i <= userDegree; i++)
    {
        result = result * userNumber;
    }
    return result;
}

int check()  // функция проверки числа и степени на натуральность
{
    do
    {
        printInConsoleWithColor("Необходимо ввести число и степень в виде натуральных чисел", ConsoleColor.DarkRed);
        getUserNumberAndDegree();
    }
    while(userNumber < 1 || userDegree < 1);
    return userNumber;
    return userDegree;
}

void answer(int userNumber, int userDegree) // функция получения результата и его вывода
{
    int result = getResultFromDegreeOfNumber(userNumber, userDegree);
    printInConsoleWithColor($"При возведении числа {userNumber} в степень {userDegree} получится {result}", ConsoleColor.Green);
}

// Решение:

getUserNumberAndDegree();

if(userNumber > 0 && userDegree > 0)  
{
    answer(userNumber, userDegree);
}
else
{
    check();
    answer(userNumber, userDegree);
}
