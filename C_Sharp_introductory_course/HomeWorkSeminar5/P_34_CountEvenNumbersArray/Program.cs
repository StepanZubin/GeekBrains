// Задача 34. Задать массив заполненный случайными положительными 
// трёхзначными числами. Написать программу, которая покажет 
// количество чётных чисел в массиве: [345, 897, 568, 234] -> 2

Console.Clear();
Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numRandom = new int[size];
SetArray(numRandom);

int count = 0;
for (int i = 0; i < numRandom.Length; i++)
{
    if (numRandom[i] % 2 == 0)
    {
        count++;
    }
}
Console.Write("-> Even numbers: " + count);


void SetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++ )
    {
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
    }
}
