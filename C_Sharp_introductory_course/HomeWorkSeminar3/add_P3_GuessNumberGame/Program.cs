// Доп.Задача 3. Игра угадайка. Программа загадывает случайное число. 
// Пользователь его угадывает. Если пользователь дает неправильный ответ, 
// то программа сообщает, больше загаданное число или меньше. 
// На отгадывание дается 3 попытки.

int numRandom = new Random().Next(1, 11);
Console.WriteLine(numRandom);
Console.WriteLine("Компьютер загадал число от 1 до 10.");
Console.WriteLine("Угадайте загаданное число.");
Console.WriteLine("У вас есть 3-и попытки: ");

int count = 0;

while (count < 3)
{
   
    int numAnswer = Convert.ToInt32(Console.ReadLine());
    if (numAnswer == numRandom)
    {
        Console.WriteLine("Верно! ");
        return;
    }
    else if (numAnswer < numRandom)
    {
        Console.WriteLine("Загаданное число больше. ");
    }
    else if (numAnswer > numRandom)
    {
        Console.WriteLine("Загаданное число меньше. ");
    }
    count++;
}