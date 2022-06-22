//Задача 32: Напишите программу замена 
//элементов массива: положительные 
//элементы замените на соответствующие 
//отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = {-4, -8, 8, 2};
Console.Clear();
OutArray(array);

Console.Write(" -> [");
for (int i = 0; i < array.Length; i++)
{
    array[i] = -array[i];
    Console.Write(array[i] + " ");
}
Console.Write("]");

void OutArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++ )
    {
        Console.Write(array[i] + " ");
    }
    Console.Write("]");
}