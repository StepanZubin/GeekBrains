// Задача 72. Заданы 2 массива: info и data. В массиве info хранятся 
// двоичные представления нескольких чисел (без разделителя). 
// В массиве data хранится информация о количестве бит, которые занимают 
// числа из массива info. Напишите программу, которая составит массив 
// десятичных представлений чисел массива data с учётом информации из массива info.
// входные данные:
// data = {0, 1, 1, 1, 1, 0, 0, 0, 1 }
// info = {2, 3, 3, 1 }
// выходные данные:
// 1, 7, 0, 1

/*
int[] data ={0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };

int[] decimalNumbers = GetNumbersFromDataInfo(data, info);

Console.Write("data = ");
PrintArray(data);

Console.Write("info = ");
PrintArray(info);

Console.Write("result = ");
PrintArray(decimalNumbers);

int GetDecimal(int[] bits, int minIdx, int maxIdx)//перевод в десятичные представления
{
    int number = 0; 
    for (int i = minIdx; i < maxIdx + 1; i++)
    {
        number += bits[i] * (int)Math.Pow(2, maxIdx - i);//конвертировать в int
    }
    return number;
}

int[] GetNumbersFromDataInfo(int[] bits, int[] sizes)//говорит какие числа нужно переводить
{
    int[] numbers = new int[sizes.Length];

    int startIdx = 0;
    int endIdx = -1;
    for (int i = 0; i < numbers.Length; i++)
    {
        startIdx = endIdx + 1;
        endIdx = endIdx + sizes[i];
        int number = GetDecimal(bits, startIdx, endIdx);
        numbers[i] = number;
    }
    return numbers;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}
*/

int[] data ={0, 1, 1, 1, 1, 0, 0, 0, 1 };
int[] info = {2, 3, 3, 1 };

Console.Write("data = ");
PrintArray(data);

Console.Write("info = ");
PrintArray(info);

int[] result = new int[info.Length];
int index = 0;
for (int i = 0; i < info.Length; i++)
{
    for (int j = 0; j < info[i]; j++)
    {
        result[i] += (int)Math.Pow(2, j) * data[index + info[i] - 1 - j];
    } 
    index += info[i];  
}

Console.Write("result = ");
PrintArray(result);


void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

