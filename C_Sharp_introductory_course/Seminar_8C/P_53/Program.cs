// Задача 53: Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int m = Input("Enter m: ");
int n = Input("Enter n: ");
int[,] numbers = new int[m, n];
SetArray(numbers);
PrintArray(numbers);
Console.WriteLine();
RearrangeLines(numbers);
PrintArray(numbers);

void RearrangeLines(int[,] arr)
{
    int temp = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            if (i == 0)
            {
                temp = arr[i, j];
                arr[i, j] = arr[arr.GetLength(0) - 1, j];
                arr[arr.GetLength(0) - 1, j] = temp;
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
