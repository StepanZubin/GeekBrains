// Задача 58. Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.

Console.Clear();
int m = new Random().Next(2, 10); // переменные для размеров массива first
int n = 1;        
int f = 2;                       // переменные для размеров массива second
int k = new Random().Next(2, 10);

while (n != f ) // количество столбцов (n) первой матрицы должно быть равно количеству строк (f) второй матрицы
{ 
    n = new Random().Next(2, 10);
    f = new Random().Next(2, 10);
}

int[,] firstNumbers = new int[m, n];
SetArray(firstNumbers);
Console.WriteLine($"Sizes first array:  m = {m}; n = {n}.");
PrintArray(firstNumbers);
Console.WriteLine();

int[,] secondNumbers = new int[f, k];
SetArray(secondNumbers);
Console.WriteLine($"Sizes second array: f = {f}; k = {k}.");
PrintArray(secondNumbers);
Console.WriteLine("---------------------------------------------");

int[,] productNumbers = MultiplicationTwoMatrices(firstNumbers, secondNumbers);
Console.WriteLine($"The product of the first and second matrices: ");
PrintArray(productNumbers);
Console.WriteLine();


int[,] MultiplicationTwoMatrices(int[,] one, int[,] two) // произведение массивов
{   
    int[,] arr = new int[one.GetLength(0), one.GetLength(1)];

    if (one.GetLength(1) > two.GetLength(1) || one.GetLength(0) < f || one.GetLength(1) < two.GetLength(1)) 
    {                                                   // условия изменения размеров итогового массива arr 
        arr = new int[one.GetLength(0), two.GetLength(1)];
    }

    for (int i = 0; i < one.GetLength(0); i++)
    {
        for (int j = 0; j < two.GetLength(1); j++)
        {
            for (int z = 0; z < two.GetLength(0); z++)
            {
                arr[i, j] += one[i, z] * two[z, j];
            }
        }
        
    } 
    return arr;
} 

void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 4}", arr[i, j]));
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