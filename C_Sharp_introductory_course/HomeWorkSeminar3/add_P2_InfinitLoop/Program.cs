// Доп.Задача 2(4). Есть программа с бесконечным циклом. 
// Когда пользователь вводит exit программа заканчивается. 
// Добавить к программе еще 4 команды (их можно придумать самому). 
// Например: SetName – Установить имя; Help – вывести список команд; 
// SetPassword – Установить пароль; SetName – Установить имя
// WriteName – вывести имя после ввода пароля; Exit – выход



//string stop = "exit";
string text = "";
int[] password = new int[4];
string name = "";


Console.Clear();

for (; text != "exit";)
{
    if (text == "Help")
    {
        Console.WriteLine("SetName - Установить Имя");
        Console.WriteLine("SetPassword - Установить Пароль");
        Console.WriteLine("WriteName - Вывести имя после ввода пароля");
        Console.WriteLine("Help - Вывести список команд");
        Console.WriteLine("Edit - Выход");
    }
    if (text == "SetPassword")
    {
        int[] password = new int[4];
        Console.WriteLine("Введите пароль (4 цифры ): **** ");
        UserArray(password);
    }
    if (text == "WriteName")
    {   
        int[] password2 = new int[4];
        Console.WriteLine("Введите пароль: **** ");
        UserArray(password2);
        for (int i = 0, j = 0; i < 4; i++)
        {
            if (password[i] == password2[j])
            {
            Console.Write(name);
            }
        }
    }
    if (text == "SetName")
    {
        Console.Write("Введите имя: ");
        name = Console.ReadLine();
    } 
   
    Console.Write("Введите команду: ");
    text = Console.ReadLine();
}  


void UserArray(int[] num) // пользовательский ввод
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write($"{i + 1}-ю цифрa: ");
        num[i] = Convert.ToInt32(Console.ReadLine());
    }
}