// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу, 
// которая удалит строку и столбец, на пересечении которых расположен 
// наименьший элемент массива.Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент -> 1, на выходе получим следующий массив:
// 9 2 3
// 4 2 4
// 2 6 7

Console.Clear();
int m = Input("Enter m: ");
int n = Input("Enter n: ");
int[,] numbers = new int[m, n];
SetArray(numbers);
PrintArray(numbers);

int min = int.MaxValue; // максимальное значение
int x = int.MaxValue;
int y = int.MaxValue;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (numbers[i, j] < min) 
        {
            min = numbers[i, j];
            x = i;
            y = j;
        }
    }
} 
Console.WriteLine("Smallest element: " + min +"[" + x + ", " + y + "]");
   
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (i != x && j != y)
        {
            Console.Write(String.Format("{0, 2}", numbers[i, j]));
        }
    }
    if (i != x) Console.WriteLine();
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 2}", arr[i, j]));
        }
        Console.WriteLine();
    } 

}

void SetArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(10);
        }
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
