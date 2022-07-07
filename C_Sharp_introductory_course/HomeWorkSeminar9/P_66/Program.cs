// Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N:
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Enter M: ");
int numM = int.Parse(Console.ReadLine());
Console.Write("Enter M: ");
int numN = int.Parse(Console.ReadLine());
int sum = numM;
Console.Write(SumNaturalNumbers(numM, numN, sum));

int SumNaturalNumbers(int start, int finish, int sumNumbers)
{
    if (start == finish) return sumNumbers;
    else return ++start + SumNaturalNumbers(start, finish, sumNumbers);
}