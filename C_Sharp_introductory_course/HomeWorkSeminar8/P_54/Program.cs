// Задача 54. Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

Console.Clear();
int m = Input("Enter m: ");
int n = Input("Enter n: ");
int[,] numbers = new int[m, n];
SetArray(numbers);
PrintArray(numbers);
Console.WriteLine("----------");
SortingRowsArray(numbers);
PrintArray(numbers);


void SortingRowsArray(int[,] arr)// сортировка строк выбором
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            int size = arr.GetLength(1);
            int indexMax = 0, index = 0;
            while (size > 1)
            {
                while (index < size)
                {
                    if (arr[i, index] < arr[i, indexMax])
                    {
                        indexMax = index;
                        index++;
                    }
                    else index++;
                }
                int temp = arr[i, indexMax];
                arr[i, indexMax] = arr[i, size - 1];
                arr[i, size - 1] = temp;

                indexMax = 0;
                index = 0;
                size--;      
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
