/*  Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5          */
// пользователь вводит
int userNumber = 0;
int enterUserNumber()   //функция по вводу числа юзером, вывод идет интовым числом
{
    Console.WriteLine("Введите число для проверки на количество цифр в нем");
    userNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Вы ввыле число {userNumber}");
    return userNumber;
}
enterUserNumber();
userNumber = Math.Abs(userNumber);
int result = 1; 
if(userNumber != 0)
{
    result = (int)Math.Log10(userNumber) + 1;
}
Console.WriteLine($"В числе {userNumber} количество цифр {result}");

