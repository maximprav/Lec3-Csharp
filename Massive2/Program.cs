// Сортировка массива
Console.Clear();
int[] arr = { 1, 5, 2, 3, 4, 7, 6, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i=0; i<count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SortArray(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SortArray(arr);
PrintArray(arr);