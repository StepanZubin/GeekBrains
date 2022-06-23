// Задача 36. Задать одномерный массив, заполненный случайными 
// числами. Найти сумму элементов, стоящих на нечётных позициях: 
// [3, 7, 23, 12] -> 19;  [-4, -6, 89, 6] -> 0.

Console.Clear();
Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

SetArray(numbers);
SumElements(numbers);

void SumElements(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum += array[i];
    }
    Console.Write("-> " + sum);
}

void SetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 100);
        Console.Write(array[i] + " ");
    }
}
