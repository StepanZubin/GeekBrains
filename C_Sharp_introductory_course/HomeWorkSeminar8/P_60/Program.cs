// Задача 60. Сформируйте трёхмерный массив из неповторяющихся 
// двузначных чисел. Напишите программу, которая будет построчно 
// выводить массив, добавляя индексы каждого элемента.

int x = 1, y = 1, z = 1;
int product = 89; // кол-во положительных двузначных чисел

while (product >= 89) // рандомные размеры массива
{
    x = new Random().Next(2, 10);
    y = new Random().Next(2, 5);
    z = new Random().Next(2, 4);
    product = x * y * z;
}

Console.Clear();
Console.WriteLine(" number of columns: x = " + x);
Console.WriteLine("    number of rows: y = " + y);
Console.WriteLine("size 'array depth': z = " + z);
Console.WriteLine("-------------------------");

int[,,] numbers = new int[z, y, x]; // z - лист, y - строка, x - столбец
SetArrayRandomUniqueNumbers(numbers);
PrintArrayThreeDimensional(numbers);


void PrintArrayThreeDimensional(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int f = 0; f < arr.GetLength(2); f++)
            {
                Console.Write(String.Format("{0, 4}", arr[i, j, f]));
                Console.Write($"[{i}, {j}, {f}]");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void SetArrayRandomUniqueNumbers(int[,,] arr)
{
  int[] temp = new int[arr.GetLength(0) * arr.GetLength(1) * arr.GetLength(2)];
  
  for (int i = 0; i < temp.Length; i++) // заполнение неповторяющимися числами одномерного массива 
  {
      temp[i] = new Random().Next(10, 100); 
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j]) 
        temp[i] = new Random().Next(10, 100);  
      }
  }

  int count = 0; 
  for (int f = 0; f < arr.GetLength(0); f++) // переписывание одномерного массива в трёхмерный
  {
    for (int i = 0; i < arr.GetLength(1); i++)
    {
      for (int j = 0; j < arr.GetLength(2); j++)
      {
        arr[f, i, j] = temp[count];
        count++;
      }
    }
  }
}


/*
// Решение с применением метода неповторяющихся чисел (Вариант 2)
int x = 1, y = 1, z = 1;
int product = 89; // кол-во положительных двузначных чисел

while (product >= 89) // рандомные размеры массива
{
    x = new Random().Next(2, 10);
    y = new Random().Next(2, 5);
    z = new Random().Next(2, 4);
    product = x * y * z;
}

Console.Clear();
Console.WriteLine(" number of columns: x = " + x);
Console.WriteLine("    number of rows: y = " + y);
Console.WriteLine("size 'array depth': z = " + z);
Console.WriteLine("-------------------------");

int[,,] numbers = new int[z, y, x]; // z - лист, y - строка, x - столбец
SetThreeDimensionalArray(numbers); 
PrintArrayThreeDimensional(numbers);


void PrintArrayThreeDimensional(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int f = 0; f < arr.GetLength(2); f++)
            {
                Console.Write(String.Format("{0, 4}", arr[i, j, f]));
                Console.Write($"[{i}, {j}, {f}]");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

void SetThreeDimensionalArray(int[,,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int f = 0; f < arr.GetLength(2); f++)
            {
              arr[i, j,f] = UniqueNumbers(arr); // метод в методе
            }
        }
    }
}

int UniqueNumbers(int[,,] array) // метод неповторяющихся(двузначные +/-) чисел (от Бориса)
{
    int number;
    while (true)
    {
        bool check = true;
        int optingPositiveNegative = new Random().Next(2);
        if (optingPositiveNegative != 0) number = new Random().Next(10, 100);
        else number = new Random().Next(-99, -10);
        for (int k = 0; k < array.GetLength(0); k++)
        {
            for (int i = 0; i < array.GetLength(1); i++)
            {
                for (int j = 0; j < array.GetLength(2); j++)
                {
                    if (array[k, i, j] == number) check = false;
                }
            }
        }
        if(check == true) return number;
    }
}
*/


/* 
//решение с семинара
int dimension1 = InputInt("Введите размерность 1: ");
int dimension2 = InputInt("Введите размерность 2: ");
int dimension3 = InputInt("Введите размерность 3: ");
int countNumbers = 89;

if(dimension1 * dimension2 * dimension3 > countNumbers)
{
    Console.WriteLine("Массив слишком большой!");
    return;
}

int[,,] numbers = CreateArray(dimension1, dimension2, dimension3);

for(int i = 0; i < numbers.GetLength(0); i++)
{
    for(int j = 0; j < numbers.GetLength(1); j++)
    {
        for(int k = 0; k < numbers.GetLength(2); k++)
        {
            Console.Write($"[{i},{j},{k}] {numbers[i, j, k]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,,] CreateArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] digitValues = new int[countNumbers];
    int value = 10;
    for(int i = 0; i < digitValues.Length; i++)
        digitValues[i] = value++;

    for(int i = 0; i < digitValues.Length; i++)
    {
        int randomIndex = new Random().Next(0, digitValues.Length);
        int temp = digitValues[i];
        digitValues[i] = digitValues[randomIndex];
        digitValues[randomIndex] = temp;
    }

    int valueIndex = 0;
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] = digitValues[valueIndex++];
            }
        }
    }

    return array;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/