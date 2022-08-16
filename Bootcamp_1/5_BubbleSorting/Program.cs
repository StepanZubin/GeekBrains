/* Сортировка пузырьком
Начальный массив: [3, 1, 5, 0, 7, 9, 8]
1. [1, 3, 5, 0, 7, 9, 8]
2. [1, 3, 0, 5, 7, 9, 8]
3. [1, 0, 3, 5, 7, 9, 8]
4. [0, 1, 3, 5, 7, 9, 8]
5. [0, 1, 3, 5, 7, 8, 9] 
*/

Console.Write("Enter the number of array elements n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < array.Length; i++)
{
    Console.Write($"Enter array[{i}]: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Initial array: [" + string.Join(", ", array) + "]");
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    for (int j = 0; j < array.Length - 1; j++)
    {
        if (array[j] > array[j + 1])
        {
            int temp = array[j];
            array[j] = array[j + 1];
            array[j + 1] = temp;
        }
    }
    Console.WriteLine(i + "[" + string.Join(", ", array) + "]");
}