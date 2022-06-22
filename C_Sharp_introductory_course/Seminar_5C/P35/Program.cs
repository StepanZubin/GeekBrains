// Задача 35: Задайте одномерный массив из 123 
//случайных чисел. Найдите количество элементов 
//массива, значения которых лежат в отрезке 
//[10,99]. Пример для массива из 5, а не 123 
//элементов. В своём решении сделайте для 123
//[5, 18, 123, 6, 2] -> 1
//[1, 2, 3, 6, 2] -> 0
//[10, 11, 12, 13, 14] -> 5

int n = 123;
int[] array = new int[n];
Console.Clear();
ArrayRandom(array);

int counter = 0;
for(int i = 0; i < 123; i++)
{
    if(array[i] >= 10 && array[i] <= 99) 
    counter++;
}

Console.WriteLine();
Console.WriteLine("// в отрезке [10, 99] -> " + counter + " элем.");


// рандомный ввод + вывод массива
void ArrayRandom(int [] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1000);
        Console.Write(array[i] + " ");
    }
}
