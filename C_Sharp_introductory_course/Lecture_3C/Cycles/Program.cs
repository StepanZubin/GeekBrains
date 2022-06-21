// Цикл со счетчиком - цикл for Цикл в цикле.
// - Всё собирает в себе 
// - Синтаксис: вводим в программу for, включаем инициализацию счетчика, 
//   далее идет проверка условия, учитывается инкремент 
//   (увеличение счетчика). 
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WrieLine(res);  



// Цикл в цикле
// Программа по  выводу таблицы умножения на экран, 
// так, чтобы таблица выводилась не одним единым столбцом, 
// а с пробелами.
for (int i = 1; i <= 10; i++)
{    
    for (int j = 1; j < 11; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine(""); //разделение блоков таблицы
}
