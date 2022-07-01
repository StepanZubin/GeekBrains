// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается 
// элемент входных данных.
// 1, 2, 3 
// 4, 6, 1 
// 2, 1, 6
// 1 встречается 3 раза 
// 2 встречается 2 раз 
// 3 встречается 1 раз 
// 4 встречается 1 раз 
// 6 встречается 2 раза

Console.Clear();
int m = Input("Enter m: ");
int n = Input("Enter n: ");
int[,] numbers = new int[m, n];
SetArray(numbers);
PrintArray(numbers);

int max = int.MinValue; // минимальное значение
int size = MaxNumberArray(numbers, max);
int[] oneArray = new int[size + 1];

for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        for (int f = 0; f < oneArray.Length; f++)
        {
            if (f == numbers[i, j])
            {
                oneArray[f]++;
                break;
            }
        }
    }
}

for (int i = 0; i < oneArray.Length; i++)
{
    Console.WriteLine($"number: {i} occurs in the array {oneArray[i]} times");
}

int MaxNumberArray(int[,] arr, int z) // макс. число в двумерном массиве
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] > z) z = arr[i, j];
        }
    } 
    return z;
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
