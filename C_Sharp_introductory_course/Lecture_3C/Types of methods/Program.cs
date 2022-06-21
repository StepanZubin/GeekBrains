//4 вида методов (Вид 1 и 2 - void методы)


//Вид 1: не принимают никаких аргументов, ничего не возвращают. 
// - Ключевое слово - void(пустота). 
// - Использование ( ) обязательно!
// - Как вызывать: указать идентификатор этого метода и ()
void Method1();
{
    Console.WriteLine('Автор ...');
}
// Вызов:
Method1();



//Вид 2: методы, которые могут принимать какие-то аргументы, 
//но в то же время ничего не возвращают.
// - Вызов функции - Method2(); 
// - Ключевое слово void, идентификатор Method2 и аргумент (string msg).
// - В этой программе можно использовать операторы и аргументы, 
//   которые были приняты. 
void Method2(string msg)
{
    Console.WriteLine(msg);
}
// Вызов: 
Method2(msg: "Текст сообщения");

// Описание:
void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Вызов: 
Method21(msg: "Текст", count: 4);
Method21(count: 4, msg: "новый текст");


//Вид 3: могут что-то возвращать, но не принимают никаких аргументов 
// - Пример – случайная генерация данных. 
// - Если метод что-то возвращает, то надо обязательно указать тип данных, 
//   значение которых мы ожидаем.
int Method3()
{
    return DateTime.Now.Year;
}
// Вызов: 
int year = Method3();
//Console.WrieLine(year);


//Вид 4: что-то принимают, что-то возвращают для дальнейшей работы. 
// - Наиболее часто используется
// - Если метод что-то возвращает, то надо обязательно указать тип данных, 
//   значение котороых мы ожидаем.
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);

// Описание:
string Method4(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method4(10, "z");
Console.WriteLine(res);
