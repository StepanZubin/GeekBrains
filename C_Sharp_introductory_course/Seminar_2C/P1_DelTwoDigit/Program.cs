/* Задача 1. Написать программу, которая выводит 
случайное трёхзначное число и удаляет вторую цифру 
этого числа: 456 -> 46. */

Console.Clear();
int num = new Random().Next(100, 1000);
Console.Write(num);

num = num /100 * 10 + num % 10;
Console.Write(" -> " + num);
