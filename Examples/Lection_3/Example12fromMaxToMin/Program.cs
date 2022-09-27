int [] arr = { 5, 7, 1, 3, 2, 4, 9, 6, 1, 8, 3 };

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++) Console.Write($"{array[i]} ");
    Console.WriteLine();
}

void SelectionSortMaxMin (int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSortMaxMin(arr);

PrintArray(arr);