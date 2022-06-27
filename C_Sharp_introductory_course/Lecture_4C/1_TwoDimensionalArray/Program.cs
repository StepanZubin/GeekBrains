/*
string[,] table = new string[2, 5];
// String.Empty - константа инициализации строк (по умолчанию)
// table[0, 0]  table[0, 1]  table[0, 2]  table[0, 3]  table[0, 4]
// table[1, 0]  table[1, 1]  table[1, 2]  table[1, 3]  table[1, 4]

table[1, 2] = "слово";

// цикл в цикле для вывода двумерного массива
for (int rows = 0; rows < 2; rows++) // 2-е строки
{
    for (int columns = 0; columns < 5; columns++) // 5-ть столбцов
    {
        Console.WriteLine($" - {table[rows, columns]}");
    }
}
*/

/*
// Метод вывода двумерного массива
int[,] matrix = new int[3, 4];
PrintArray(matrix);

void PrintArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
}
*/ 

/*
// Метод рандомного заполнения двумерного массива
int[,] matrix = new int[3, 4];
FillArray(matrix);

void FillArray(int[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
{ 
    for (int j = 0; j < array.GetLength(1); j++) 
    { 
        array[i, j] = new Random().Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}
}
*/


/*
// Алгоритм позволяющий закрашивать замкнутые области (ресурсоёмкий)
int[,] pic = new int[,] // необязательно указывать кол-во строчек и столбцов
{                        // так как есть фиксированные данные
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 1, 1, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 1, 1, 1, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, 
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, 
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, 
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, 
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, 
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0 }, 
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0 }, 
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 }, 
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0 }, 
    {0, 0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0 }, 
    {0, 0, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 1, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 1, 1, 0, 0, 0, 0, 0, 0, 0 }, 
    {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, 
};

PrintImage(pic);
FillImage(13, 13); // случайная точка внутри изображения
PrintImage(pic);

void FillImage(int row, int col) // закрашивание картинки
{
    if (pic[row, col] == 0)
    {
        pic[row, col] = 1;
        FillImage(row - 1, col); // идём вверх (Метод вызывает сам себя)
        FillImage(row, col - 1); // идём влево
        FillImage(row + 1, col); // мдём вниз
        FillImage(row, col + 1); // идём вправо

    }
}

void PrintImage(int[,] image)
{
    for (int i =0; i < image.GetLength(0); i++)
    {
        for (int j = 0; j < image.GetLength(1); j++)
        {
            if (image[i, j] == 0) Console.Write($" ");
            else Console.Write($"+");
        }
        Console.WriteLine();
    }
}
*/

/*
// Метод: принимающий число факториал которого нужно вычмслить
Console.WriteLine(Factorial(3)); // 3! = 1 * 2 * 3 * = 6

int Factorial(int n)
{
    if (n == 1) return 1; // 1! = 1   // 0! = 1
    else return n * Factorial(n - 1); 
}
*/

/*
Console.WriteLine(Factorial(40)); 
double Factorial(int n) // double большие числа
{
    if (n == 1) return 1; 
    else return n * Factorial(n - 1); 
}
for (int i = 1; i <= 40; i++)
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
*/

// Метод вывода числа Фибоначчи
// f(1) = 1
// f(2) = 1
// f(n) = f(n - 1) + f(n - 2)

int Fibonacci(int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 10; i++)
{
    Console.Write(Fibonacci(i) + " ");
}