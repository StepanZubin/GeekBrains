// Задача 41. Пользователь вводит с клавиатуры числа через запятую. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь:
// 0, 7, 8, -2, -2 -> 2;     -1, -7, 567, 89, 223-> 3.

Console.Write("Enter the numbers separated by commas: ");
string line = Convert.ToString(Console.ReadLine());

int count = 1;
// определение размера нового массива: int[] numbers;
for (int i = 0; i < line.Length; i++)
{
    if(line[i] == ',') // '.' - для char; "..." - для string
    {
        count++;
    }
} 

int[] numbers = new int[count];
int index = 0; // счётчик для массива: int[] numbers

// перезапись строки в числовой массив:
for (int i = 0; i < line.Length; i++)
{
    string temp = String.Empty; // пустая строка для записи char

    while (line[i] != ',')
    {
        if (i != line.Length - 1) // т.к. последняя группа char без ","
        {
            temp += line[i]; // можно: line[i].ToString(); 
            i++;
        }
        else
        {
            temp += line[i]; // последняя группа char
            break; 
        } 
    }
     numbers[index] = Convert.ToInt32(temp);
     index ++;
}

int plus = 0;
// кол-во чисел больше нуля:
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        plus++;
    }
}

Console.Clear();
PrintString(line);
Console.WriteLine(" -> " + plus);
// PrintArray(numbers);


void PrintString(string a)
{
    for (int i = 0; i < a.Length; i++)
    {
        Console.Write(a[i] + "");
    }
} 

/*
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
} 
*/

