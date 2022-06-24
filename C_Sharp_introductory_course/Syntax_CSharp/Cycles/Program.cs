// Цикл while
int count = 0;
while (count < 10)//while (true) -> бесконечный цикл
{
    Console.Write(count + " ");
    count++;
}
Console.WriteLine("-> цикл while");


// Цикл for
for (int i = 0; i < 10; i++)// for (;;) -> бесконечный цикл
{
    Console.Write(i + " ");
}
Console.WriteLine("-> цикл for");


// Оператор break (прерывает цикл) 
for (int i = 0; i < 10; i++) 
{
    if (i == 5)
    {// при заданном условии break прервёт цикл
        break;
    }
    Console.Write(i + " ");
}
Console.WriteLine("-> есть break");


// Оператор continue (прерывает итерацию не выходя из цикла)
for (int i = 0; i < 10; i++)
{
    
    if (i == 5 || i == 7)
    {// при заданном условии continue прервёт итерацию,
        continue;           //но цикл продолжит работу
    }
    Console.Write(i + " ");
}
Console.Write("-> есть continue");