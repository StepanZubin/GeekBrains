// Задача 2. Упорядочиванию данных внутри массива посредством 
// алгоритма сортировки методом выбора (или методом минимакса)
// Bмеется какая-то последовательность чисел: 6 8 3 2 1 4 5 7.

int[] arr = {6, 8, 3, 2, 1, 4, 5, 7};

void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        if (i < count - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine();
}

void SelectionSortDirect(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

void SelectionSortRevers(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }
        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

Console.Clear();
Console.Write("Original: ");
PrintArray(arr);

SelectionSortDirect(arr);
Console.Write("  Direct: ");
PrintArray(arr);

SelectionSortRevers(arr);
Console.Write(" Reverse: ");
PrintArray(arr);