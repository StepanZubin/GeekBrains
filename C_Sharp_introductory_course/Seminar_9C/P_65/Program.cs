// Задача 65: Задайте значения M и N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Введите N: ");
int numN = int.Parse(Console.ReadLine());
Console.Write(NaturalNumber(numM, numN));

int NaturalNumber(int num1, int num2)
{
    if (num2 == num1)
        return num2;
    else
        Console.Write($"{NaturalNumber(num1, num2 - 1)}, ");

    return num2;
}


/*
// Решение Дениса с int (return)
int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
Console.WriteLine(NaturalNumber(m, n));
 
int NaturalNumber(int m, int n)
{
    if (m == n)
    {
       return n;
    } 
    if (m < n)
    {
        Console.Write($"{NaturalNumber(m, n - 1)}, ");
    }
    if (m > n)
    {
        Console.Write($"{NaturalNumber(m, n + 1)}, ");
    }

    return n;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/


/*
// Решение Дениса с void
int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
NaturalNumber(m, n);
 
void NaturalNumber(int m, int n)
{
    if (m == n)
    {
        Console.Write($"{m} ");
    } 
    if (m < n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m + 1, n);
    }
    if (m > n)
    {
        Console.Write($"{m}, ");
        NaturalNumber(m - 1, n);
    }
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}
*/