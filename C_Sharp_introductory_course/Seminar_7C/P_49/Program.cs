// Задача 49. Задать двумерный массив. Найдите элементы, у которых 
// оба индекса нечётные, и замените эти элементы на их квадраты.
// Например, изначально массив выглядел вот так: 1 4 7 2
//                                               5 9 2 3
//                                               8 4 2 4
// Новый массив будет выглядеть вот так: 1  4 7 2
//                                       5 81 2 9
//                                       8  4 2 4

int m = Input("Enter m: ");
int n = Input("Enter n: ");

int[,] numbers = new int[m, n];
SetArray(numbers);
PrintArray(numbers);
Console.WriteLine();
SquaredOddIndexNumbers(numbers);
PrintArray(numbers);

void SquaredOddIndexNumbers(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            {
                numbers[i, j] *= numbers[i, j];
            }
        }
    }
}


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