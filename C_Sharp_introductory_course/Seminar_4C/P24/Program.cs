// Задача 24. Написать программу, которая принимает на вход 
// число (А) и выдаёт сумму чисел от 1 до А:   7 -> 28.

Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
//int i = 1;
int sum = 0;

/*
while (i <= a)
{
    sum += i;
    i++;
}  */

for (int i = 1; i <= a; i++) //Цикл for
{
    sum += i;
} 

Console.WriteLine(sum); 

