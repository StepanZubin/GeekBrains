// Задача 52. Задать двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int m = Input("Enter m: ");
int n = Input("Enter n: ");
int[,] numbers = new int[m, n];

SetArray(numbers);
PrintArray(numbers);
Console.WriteLine("___________________________");
Console.WriteLine("Arithmetic mean of columns:");
ArithmeticMeanToColumn(numbers);

void ArithmeticMeanToColumn(int[,] arr)
{
    int countColumn = 0;
    while (countColumn < n)
    {
        double sum = 0;
        int count = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                if (j == countColumn)
                {
                    sum += arr[i, j];
                    count++;
                }
            }
        }
        Console.Write(String.Format("{0,6}", Math.Round(sum / count, 1)));
        countColumn++;
    }
}

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0,6}", arr[i, j]));
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
            arr[i, j] = new Random().Next(100);
        }
    }
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}