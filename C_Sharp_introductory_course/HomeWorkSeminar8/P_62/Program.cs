// Задача 62. Заполните спирально массив 4 на 4
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

Console.Clear();
Console.Write("Enter the size of the square array (1, 31] n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[n, n];
SetArraySnake(num);
Console.WriteLine($" An array {n} x {n} filled in a spiral:");
PrintArray(num);


void SetArraySnake(int[,] arr)
{
  int count = 0;
  int shift = 0;  //сдвиг
  for (int j = 0; j < num.Length; j++)
  {
    for (int i = 0 + shift; i < num.GetLength(0) - shift; i++) //верхняя строка
    {
      num[0 + shift, i] = ++count;
    } 
    for (int i = 1 + shift; i < num.GetLength(1) - shift; i++) //правый столбец
    {
      num[i, num.GetLength(1) - 1 - shift] = ++count;
    } 
    for (int i = num.GetLength(0) - 2 - shift; i >= 1 + shift; i--) //нижняя строка
    {
      num[num.GetLength(0) - 1 - shift, i] = ++count;
    } 
    for (int i = num.GetLength(1) - 1 - shift; i >= 1 + shift ; i--) //левый столбец
    {
      num[i, 0 + shift] = ++count;
    } 
    shift++;
  }
}

void PrintArray(int[,] arr)
{
  for (int i = 0; i < arr.GetLength(0); i++) // вывод в консоль
  {
    for (int j = 0; j < arr.GetLength(1); j++)
    {
      Console.Write(String.Format("{0, 4}", num[i, j]));
    }
    Console.WriteLine();
  }
  Console.WriteLine();
}


/*
// Решение с семинара
Console.Write("Введите размерность массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[n, n];

int value = 1;
int i = 0;
int j = 0;

while(value <= n * n)
{
    array[i, j] = value;
    if(i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++value;
}

for(int x = 0; x < array.GetLength(0); x++)
{
    for(int y = 0; y < array.GetLength(1); y++)
    {
        Console.Write(array[x, y] + " ");
    }
    Console.WriteLine();
}

*/