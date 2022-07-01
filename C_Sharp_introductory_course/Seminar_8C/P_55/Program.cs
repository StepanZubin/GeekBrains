// Задача 55: Задайте двумерный массив. Напишите программу, которая 
// заменяет строки на столбцы. В случае, если это невозможно, программа 
//должна вывести сообщение для пользователя.

int n = Input("Array n x n. Enter n: ");
int[,] numbers = new int[n, n]; // если кол-во строк != кол-ву столбцов
SetArray(numbers);              // то поменять местами не получиться
PrintArray(numbers);            // из-за свойства массива (фикс. размер)
Console.WriteLine();
numbers = SwapRowsAndColumns(numbers);
PrintArray(numbers);

int[,] SwapRowsAndColumns(int[,] arr)
{
    int[,] tempArray = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            tempArray[i, j] = arr[j, i];
        }
        
    } 
    return tempArray;
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
