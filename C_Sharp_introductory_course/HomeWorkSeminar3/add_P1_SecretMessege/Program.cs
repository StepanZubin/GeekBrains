// Доп.Задача 1. В переменной string есть секретное сообщение, 
// во второй - есть пароль. Пользователю программы даётся 
// 3 попытки ввести пароль и увидеть секретное сообщение.

string secret = "Пешеход был скорее прав, чем жив";
int password = 1234; 

Console.Clear();
Console.WriteLine("Введите пароль. 3 попытки: **** ");
int enter1 = Convert.ToInt32(Console.ReadLine());

if (password == enter1)
{
    Console.Clear();
    Console.Write(secret);
    return;
}
else 
{
    Console.Clear();
    Console.WriteLine("Неверный пароль. 2 попытки: **** ");
}  

int enter2 = Convert.ToInt32(Console.ReadLine());
if (password == enter2)
{
    Console.Clear();
    Console.Write(secret);
    return;
}
else 
{
    Console.Clear();
    Console.WriteLine("Неверный пароль. 1 попытка: **** ");
} 

int enter3 = Convert.ToInt32(Console.ReadLine());
if (password == enter3)
{
    Console.Clear();
    Console.Write(secret);
    return;
}
else 
{
    Console.Clear();
    Console.Write("Попытки закончились");
}  
