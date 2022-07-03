
// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

Console.Clear();
int m = 1, n = 1;
while (m == n) //размеры прямоугольного массива
{
    m = new Random().Next(3, 7);
    n = new Random().Next(3, 10);
}
Console.WriteLine($"Array sizes: m = {m}; n = {n}");
Console.WriteLine("-------------------------");

int[,] numbers = new int[m, n];
SetArray(numbers);
PrintArray(numbers);
Console.WriteLine("--------------------------");

int sumMin = int.MaxValue;
int sumTemp = 0;
int indexMin = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sumTemp += numbers[i, j];
    }
    if (sumTemp < sumMin) 
        {
            indexMin = i;
            sumMin = sumTemp;
        }
    sumTemp = 0;
} 
Console.WriteLine($"index row with min sum: {indexMin};");
Console.WriteLine($"Sum elements in row: {sumMin}.");
Console.WriteLine("--------------------------");

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