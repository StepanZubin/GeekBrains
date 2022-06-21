// Задача 29. Написать программу, которая задаёт массив 
// из 8 элементов и выводит их на экран. Вывод сделать 
// отдельным методом:
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] num = new int[8];
SetArray(num);
Console.Clear();
OutputArray(num);

void SetArray(int[] num) //М: задать массив
{
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = new Random().Next(100);
    }
}

void OutputArray(int[] num) //М: вывод массива
{
    for (int j = 0; j < num.Length; j++)
    {
        Console.Write($"{num[j]} ");
    }
}


