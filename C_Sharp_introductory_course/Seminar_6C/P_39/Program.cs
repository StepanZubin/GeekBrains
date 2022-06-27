//Задача 39: Написать программу, которая перевернёт 
//одномерный массив (последний элемент будет на 
//первом месте, а первый - на последнем и т.д.)
//[1 2 3 4 5] -> [5 4 3 2 1]; [6 7 3 6] -> [6 3 7 6].

Console.Write("Enter size array: ");
int size = Convert.ToInt32(Console.ReadLine()); 
int[] numbers = new int[size];

Console.Clear();
SetArray(numbers);
Console.Write(" -> ");
ReversArray(numbers);


void SetArray(int[] num) //рандомный набор массива + вывод
{
    Console.Write("[");
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(10);
        Console.Write(num[i]);

        if (i != num.Length - 1)
        { 
            Console.Write(", ");
        }   
    }
    Console.Write("]");
}

void ReversArray(int[] num) //разворот массива + вывод
{
    Console.Write("[");
    for (int i = num.Length - 1; i >= 0; i--)
    {
        Console.Write(num[i]);

        if (i != 0)
        { 
            Console.Write(", ");
        }   
    }
    Console.Write("]");
} 

/*
// Решение с семинара   
int[] numbers = {1, 2, 3, 4, 5};
int[] tempArray = new int[numbers.Length];

for(int i = 0; i < numbers.Length; i++)
{
    tempArray[i] = numbers[numbers.Length - 1 - i];
}

numbers = tempArray;

for(int i = 0; i < numbers.Length; i++)
{
    Console.Write(numbers[i] + " ");
}
*/