// Задача 45: Написать программу, которая будет 
//создавать копию заданного массива с помощью 
//поэлементного копирования.

Console.Clear();
int N = Input("Введите число: ");
int[] numbers = new int[N];
SetArray(numbers);
PrintArray(numbers);
Console.WriteLine();
CopyArray(numbers);
PrintArray(numbers);

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int[] CopyArray(int[] array) //копия заданного массива с 
{                           //поэлементным копировванием
    int[] copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
    return copyArray; 
}

int[] SetArray(int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(10);
    }
    return array;
}

int Input(string a)
{   
    Console.Write(a);
    return Convert.ToInt32(Console.ReadLine());
}