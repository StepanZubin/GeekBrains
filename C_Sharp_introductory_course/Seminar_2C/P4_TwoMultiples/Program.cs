/* Напишите программу, которая принимает на вход число
 и проверяет, кратно ли оно одновременно 7 и 23:
14 -> нет; 46 -> нет; 161 -> да */


/*
Console.Clear();

Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 23 == 0)
{
    Console.Write(num1 + " -> да ");
}
else
{
    Console.Write(num1 + " -> нет ");
}   */




Console.Clear();

Console.Write("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (CheckMultiples(num1, 7) && CheckMultiples(num1, 23))
{
    Console.Write(num1 + " -> да ");
}
else
{
    Console.Write(num1 + " -> нет ");
}  

bool CheckMultiples(int a, int b) // Функция проверки кратности
{
    return a % b == 0; 
}