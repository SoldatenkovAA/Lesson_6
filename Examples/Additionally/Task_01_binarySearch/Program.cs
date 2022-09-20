//пользователь вводит кол-о элементов массива и число, которое ему необходимо. Мы выводим индекс
//через бинарный поиск
//1. Пользователь вводит кол-во элементов массива и число, индекс которого нужно найти
Console.WriteLine("Введите количество элементов массива ");
int lenClient = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число, индекс которого Вам нужно найти");   
int needNum = Convert.ToInt32(Console.ReadLine());                        

// 2. Нужно создать массив на основании информации, которую пользователь ввел выше.
void FillArray(int[] name)
{
    int allmas = name.Length;
    int index = 0; 
    while (index < allmas)
    {
        name[index] = index + 1;
        index++;
    }
}
void PrintArray(int[] anyMas)
{
    int allmas2 = anyMas.Length;
    int position = 0; //счетчик
    while (position < allmas2)
    {
        Console.Write($"{anyMas[position]}  ");
        position++;
    }

}

int IndexOf(int[] anyMassive, int find)  // массив создан, тут уже пойдет бинарный поиск, трам-пам-пам
{
    int lenMas = anyMassive.Length;   
    int min = anyMassive[0];
    int max = anyMassive[lenMas - 1];
   
    while(min <= max)           
    {
        int middle = (min + max) / 2;

        if (find == anyMassive[middle])
        {
            return middle;
        }
        else if(find < anyMassive[middle])
        {
            max = middle - 1;
        }
        else 
        {
            min = middle +1;
        }
    }
    return -1; 
}

int[] massive = new int[lenClient];
FillArray(massive);
PrintArray(massive);
Console.WriteLine();

int pos = IndexOf(massive, needNum);
Console.WriteLine($"Индексом числа {needNum} будет {pos}");
