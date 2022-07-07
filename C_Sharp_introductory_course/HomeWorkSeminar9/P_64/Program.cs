
// Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1:
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Enter N: ");
int numN = int.Parse(Console.ReadLine());
int num1 = 1;
Console.Write(ReverseOrderNumbers(numN, num1));

int ReverseOrderNumbers(int start, int finish)
{
    if (start == finish) return finish;
    else Console.Write($"{ReverseOrderNumbers(start, finish + 1)}, "); 
    return finish;
}
