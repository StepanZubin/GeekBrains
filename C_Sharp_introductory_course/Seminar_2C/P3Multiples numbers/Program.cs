/* . Напишите программу, которая будет принимать на вход 
два числа и выводить, является ли второе число кратным 
первому. Если число 2 не кратно числу 1, то программа 
выводит остаток от деление: 34, 5-> не кратно, остаток 4 
16, 4-> кратно */


/*
Console.Clear();

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    if (num1 % num2 == 0)
    {
        Console.Write(num1 + " кратно: " + num2);
    }
    else 
    {
        int num0 = num1 % num2;
        Console.Write(num1 + " не кратно: " + num2 + " остаток -> " + num0);
    }
}
else if (num2 % num1 == 0)
    {
        Console.Write(num2 + " кратно: " + num1);
    }
    else 
    {
        int num0 = num2 % num1;
        Console.Write(num2 + " не кратно: " + num1 + " остаток -> " + num0);
    }  */



 
Console.Clear();

int num1 = Input("Введите первое число: ");
int num2 = Input("Введите второе число: ");

if (num1 > num2)
{
    if (num1 % num2 == 0)
    {
        Console.Write(num1 + " кратно: " + num2);
    }
    else 
    {
        int num0 = num1 % num2;
        Console.Write(num1 + " не кратно: " + num2 + " остаток -> " + num0);
    }
}
else if (num2 % num1 == 0)
    {
        Console.Write(num2 + " кратно: " + num1);
    }
    else 
    {
        int num0 = num2 % num1;
        Console.Write(num2 + " не кратно: " + num1 + " остаток -> " + num0);
    }

int Input(string output) //Функция ввода
{
    Console.Write(output);
    return Convert.ToInt32(Console.ReadLine());
}