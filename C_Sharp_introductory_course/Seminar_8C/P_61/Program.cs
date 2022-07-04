// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

Console.Clear();
int[,] matrixSecond = CreateMatrixRandomInteger();
PrintMatrix(matrixSecond);


int[,] CreateMatrixRandomInteger()
{
    int row = Input("Введите колличество строк: ");
    int column = row * 2 - 1;
    int center = row-1; // центральный индекс столбцов
    int left = center;
    int right = center;
    int[,] matrix = new int[row, column];

    for (int i = 0; i < row; i++) // заполнение единицами
    {
        for (int j = 0; j < column; j++)
        {
            if (left == j && right == j)
            {
                matrix[i, j] = 1;
                left--;
                right++;
                break;
            }
            else if (left == j )
            {
                matrix[i, j] = 1;
                left--;
            }
            else if (right == j)
            {
                matrix[i, j] = 1;
                right++;
                break;
            }
            else
            {
                matrix[i, j] = 0;
            }
        }
    } 
        for (int i = 2; i < row; i++) // заполнение числами Паскаля
        {
            for (int j = 0; j < column; j++)
            {
                if(j != 0 && j < column - 1 && matrix[i, j] == 0)
                {
                    matrix[i, j] = matrix[i - 1, j - 1] + matrix[i - 1, j + 1];
                }
            }
        } 
        return matrix;
}           

int Input(string str)
{
    Console.Write(str);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] != 0) // замена 0 на числа Паскаля
            {
                Console.Write(String.Format("{0, 2}", matrix[i, j])); // if (matrix[i, j] < 10)
            }
            else
            Console.Write(String.Format("{0, 2}", " ")); // замена  0 на пробелы (формирует равнобедренный треугольник из прямоугольного)
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
