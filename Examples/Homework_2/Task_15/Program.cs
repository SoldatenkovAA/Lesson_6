/*   Задача 15: Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет     */


/* Придумал 2 варианта функции - один через else if, второй -  в if положил if & else - оба рабочие
void checkDayOff(int number)    
{
    if (number > 0 && number <8)  
    {
        if(number > 0 && number < 6)
        {
            Console.WriteLine("Нет, этот день не является выходным");
        }
        else
        {
            Console.WriteLine("Да, этот день - выходной");
        }
    }
    else 
    {
        Console.WriteLine("Нужно ввести число от 1 до 7, попробуйте еще раз");
    }
}  */

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

void checkDayOff(int number)    
{
    if (number > 0 && number <6)  
    {
        Console.WriteLine("Нет, этот день не является выходным");
    }
    else if (number > 5 && number <8)
    {
        Console.WriteLine("Да, этот день - выходной");
    }
    else 
    {
        Console.WriteLine("Нужно ввести число от 1 до 7, попробуйте еще раз");
    }
}
checkDayOff(dayNumber);