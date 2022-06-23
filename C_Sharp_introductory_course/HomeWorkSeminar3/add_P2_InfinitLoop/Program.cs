// Доп.Задача 2(4). Есть программа с бесконечным циклом. 
// Когда пользователь вводит exit программа заканчивается. 
// Добавить к программе еще 4 команды (их можно придумать самому). 
// Например: SetName – Установить имя; Help – вывести список команд; 
// SetPassword – Установить пароль; SetName – Установить имя
// WriteName – вывести имя после ввода пароля; Exit – выход

string text = " ";
string password = " **** ";
string name = " ---- ";

for (; text != "exit";)
{
    ListCommands(text);
    SetName(text, name);
    SetPassword(text, password);
    WriteName(text, password); 

    Console.Write("Введите команду: ");
    text = Console.ReadLine();
}  


void WriteName(string a, string b)
{
    if (a == "WriteName")
    {
        Console.Write("Введите пароль: ");
        string c = Console.ReadLine();

        if (b == c)
        {
            Console.WriteLine("имя: " + name);
            return;
        }
        else
        {
            Console.WriteLine("Неверный пароль");
        } 
    }
}

void SetPassword(string a, string b)
{
    if (a == "SetPassword")
    {
        Console.Write("Введите пароль: ");
        b = Console.ReadLine();
        Console.WriteLine($"Пароль сохранён");
    }
}

void SetName(string a, string b)
{
    if (a == "SetName")
    {
        Console.Write("Введите имя: ");
        b = Console.ReadLine();
        Console.WriteLine($"Имя '{b}' сохранено");
    }
}

void ListCommands(string a)
{
    if (a == "Help")
    {
        Console.WriteLine("SetName - Установить Имя");
        Console.WriteLine("SetPassword - Установить Пароль");
        Console.WriteLine("WriteName - Вывести имя после ввода пароля");
        Console.WriteLine("Help - Вывести список команд");
        Console.WriteLine("Edit - Выход");
    }
}