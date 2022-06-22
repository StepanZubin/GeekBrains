// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да


Console.Write("Задайте размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

Console.Clear();
ArrayManual(array);
PrintArray(array);

if(SearchNumber(array, n))
{
    Console.WriteLine(" (число " + n + " - присутствует в массиве)");
}
else
{
    Console.WriteLine(" (число " + n + " - oтсутствует в массиве)");
}

// ручной ввод массива
void ArrayManual(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите " + i + "-й элемент массива: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
}

// вывод массива
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

// поиск числа
bool SearchNumber(int[] array, int number)
{
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] == number)
        return true;
    }
    return false;
}



/*
int size = InputInt("Введите размер массива: ");
int[] array = CreateArray(size);
PrintArray(array);

int[] CreateArray(int size)
{
    int[] array = new int[size];
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = InputInt("Введите элемент " + i + ": ");
    }
    return array;
}

int InputInt(string outout)
{
    Console.Write(outout);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/