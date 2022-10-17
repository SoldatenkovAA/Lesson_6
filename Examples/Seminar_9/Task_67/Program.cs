/*  Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9     */



int GetSum(int N)
{
    
    if(N ==  0)
    {
        return 0;
    }
    int digit = N % 10; 
    return digit + GetSum(N/10);
   
    
}

Console.WriteLine("Введите число ");
int N = Convert.ToInt32(Console.ReadLine());
int result = GetSum(N);
Console.WriteLine(result);