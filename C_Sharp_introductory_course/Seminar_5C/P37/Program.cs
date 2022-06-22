// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве: [1 2 3 4 5] -> 5 8 3;
// [6 7 3 6] -> 36 21.

Console.Clear();
Console.Write("Задайте размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
ArrayRandom(array);
Console.WriteLine();

int z = LengthNewArray(n);
int[] newArray = new int[z];
Console.WriteLine("Размер нового массива: " + z);

if (n % 2 == 0)
{
    for (int i = 0; i < z; i++)
    {
        newArray[i] = array[i] * array[n - 1 - i];
        Console.Write(newArray[i] + " ");
    }
}
else if (n % 2 == 1)
{
    newArray[z - 1] = array[(n - 1)/ 2];
    for (int i = 0; i < z - 1; i++)
    {   
        newArray[i] = array[i] * array[n - 1 - i];
        Console.Write(newArray[i] + " ");
    }
    Console.Write("(" + newArray[z - 1] + ")");
}


// рандомный набор массива + вывод
void ArrayRandom(int[] array)
{
    for(int i=0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,10); 
        Console.Write(array[i] + " ");
    }
}

// нахождение размера нового массива (в рамках данной задачи) 
int LengthNewArray(int a) 
{
    if (a % 2 == 0)
    {
        a /= 2;
    }
    else
    {
        a /= 2;
        a++;   // увеличиваем размер массива на 1, т.к. при делении 
    }          // нечетного числа на 2 -> остаток: 1.
    return a;
}

