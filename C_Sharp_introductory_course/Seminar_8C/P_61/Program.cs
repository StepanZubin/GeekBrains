// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

int[,] matrixSecond = CreateMatrixRandomInteger();
            PrintMatrix(matrixSecond);

            int[,] CreateMatrixRandomInteger()
            {
                int row = Input("Введите колличество строк ");
                int column = row * 2 - 1;
                int center = row-1;
                int left = center;
                int right = center;
                int[,] matrix = new int[row, column];
                for (int i = 0; i < row; i++)
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
                for (int i = 2; i < row; i++)
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
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        //Console.Write($"{matrix[i, j]} ");
                        if (matrix[i, j] != 0)
                        {

                            if (matrix[i, j] < 10)
                                Console.Write($"{matrix[i, j]}  ");
                            else if (matrix[i, j] < 100)
                                Console.Write($"{matrix[i, j]} ");
                        }
                        else
                            Console.Write("    ");
                    }
                    Console.WriteLine();
                }
            }
