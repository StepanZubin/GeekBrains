// Задача 47. Задать двумерный массив размером m × n, 
// заполненный случайными вещественными числами: m = 3, n = 4.
// 0,5  7   -2 -0,2
//  1 -3,3   8 -9,9
//  8  7,8 -7,1  9

int m = Input("Enter m: ");
int n = Input("Enter n: ");
double[,] numbers = new double[m, n];
SetArray(numbers);
PrintArray(numbers);


void PrintArray(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (arr[i, j] == -0)    // замена "-0" на "0"
            {
                Console.Write(String.Format("{0, 6}", 0)); 
            }   // String.Format("{ , }", ...); выравнивание по столбцам
            else
            {
                Console.Write(String.Format("{0, 6}", arr[i, j]));
            }
        }
        Console.WriteLine();
}
}

void SetArray(double[,] arr)
{
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = Convert.ToDouble(new Random().Next(-59, 100));
        arr[i, j] /= new Random().Next(1, 100); // добавление дробных чисел
        arr[i, j] = Math.Round(arr[i, j], 1); // метод округления
    }
}
}

int Input(string output)
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}
