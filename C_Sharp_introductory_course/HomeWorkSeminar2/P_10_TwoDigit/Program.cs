/* Задача 10. Написать программу, которая 
принимает на вход трёхзначное число и на выходе 
показывает вторую цифру этого числа. 456 -> 5 */


Console.Clear();
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine ());

if (num < -99)
{
    num = num * -1;
}

if (num > 99 && num < 1000)
{
    num = num / 10 - num / 100 * 10;
    Console.Write("Вторая цифра: " + num);
}
else
{
    Console.Write("Ошибка ввода! ");
}  
