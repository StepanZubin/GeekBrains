//Задача 31: Задайте массив из 12 элементов, заполненный случайными 
//числами из промежутка [-9, 9]. Найдите сумму отрицательных и 
//положительных элементов массива.Например, в массиве 
//[3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.

int[] array = new int[12];
int sumPositive = 0;
int sumNegative = 0;
Console.Clear();
FillArrayRandomNumbers(array);
PrintArray(array);

for(int i = 0; i < array.Length; i++)
{
    if(array[i] > 0)
        sumPositive += array[i];
    else
        sumNegative += array[i];
}
Console.WriteLine($"Сумма положительных = {sumPositive}, сумма отрицательных = {sumNegative}");


void PrintArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-9, 10);
    }
}
