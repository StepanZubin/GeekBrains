// Задача 51. Задать двумерный массив. Найдите сумму элементов, 
// находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив: 1 4 7 2
//                         5 9 2 3
//                         8 4 2 4
// Сумма элементов главной диагонали:  1 + 9 + 2 = 12.

int m = Input("Enter m: ");
int n = Input("Enter n: ");

int[,] numbers = new int[m, n];
SetArray(numbers);
PrintArray(numbers);
Console.WriteLine();
SumDiagonalNumbers(numbers);


void SumDiagonalNumbers(int[,] arr)
{
    int sum = arr[0, 0];
    Console.Write(sum);

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == j && i > 0 && j > 0)
            {
                Console.Write(" + " + arr[i, j]);
                sum += arr[i, j];
            }
        }
    }
    Console.Write(" = " + sum);
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