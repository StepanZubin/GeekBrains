﻿// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную 
// степень B:  3, 5 -> 243 (3⁵)

int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
Console.WriteLine(Numbers(m,n));

int Numbers(int m, int n)
{
    if (n == 0)
    {
        return 1; //т.к. любое число в 0-й степени = 1
    }
    else
    {
        return m * Numbers(m,n-1);
        
    }

}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}


/*
//Сем4 25
int a = Input("Введите число А: ");
int b = Input("Введите число B: ");
int n = a;

Console.Clear();
Console.Write($"{a} в {b} степени -> {Degre(a, b, n)}");

int Degre(int a, int b, int n) //М: возведение в степень
{
    for (int i = 1; i < b; i++)
    {
        n *= a;
    }
    return n;
}

int Input(string n)
{
    Console.Write(n);
    return Convert.ToInt32(Console.ReadLine());
}
*/