// Задача 46. Задать двумерный массив размером m × n, 
// заполненный случайными целыми числами: m = 3, n = 4.
// 1  4  8 19
// 5 -2 33 -2
// 77 3  8  1

int m = Input("Enter m: ");
int n = Input("Enter n: ");
int[,] numbers = new int[m, n];

SetArray(numbers);
PrintArray(numbers);


// метод вывода двумерного массива:
void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
}
}

// метод заполнения двумерного массива:
void SetArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(-99, 100);
        }
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}