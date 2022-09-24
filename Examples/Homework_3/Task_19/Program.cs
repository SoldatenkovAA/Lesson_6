/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет,
является ли оно палиндромом.
14212 -> нет
12821 -> да 
23432 -> да   
*/
Console.WriteLine("Введите пятизначное число для проверки, является ли оно палиндромом ");
int userNumber = Convert.ToInt32(Console.ReadLine());

void checkPalindrome (int number)
{
    int firstDigit = number / 10000;
    int secondDigit = number / 1000 % 10;
    int fourthDigit = number / 10 % 10;
    int fifthDigit = number % 10;
    
    if(firstDigit == fifthDigit && secondDigit == fourthDigit)
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
if(userNumber > 9999 && userNumber < 100000)
{
    checkPalindrome(userNumber);
}
else 
{
    Console.WriteLine($"Число {userNumber} не пятизначное, попробуйте ввести еще раз");
}



