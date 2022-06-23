// Задача 38: Задать массив вещественных чисел. 
// Найти разницу между максимальным и минимальным 
// элементов массива:   [3 7 22 2 78] -> 76.

Console.Write("Enter size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];

Console.Clear();
SetArray(numbers);
DifferenceMaxMin(numbers);


void DifferenceMaxMin(int[] array)
{
    int max = array[0];
    int min = array[0];

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        else if (array[i] < min)
        {
            min = array[i];
        }
    }

    Console.Write($" ->  {max - min}");
}

void SetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100);
        Console.Write(array[i] + " ");
    }
}



    
    