/*
[6, 15, 2, 9, -3]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
2 > -3
MIN = -3
[-3, 6, 15, 2, 9]
[6, 15, 2, 9]
MIN = 6
6 < 15
6 > 2
MIN = 2
2 < 9
[-3, 2, 6, 15, 9]
MIN = 6
6 < 15
6 < 9
[-3, 2, 6, 15, 9]
MIN = 15
15 > 9
[-3, 2, 6, 9, 15]
*/

// СОРТИРОВКА ЧИСЕЛ (ВЫБОРОМ)
Console.Write("Enter the number of array elements n: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
// Заполнение массива пользователем
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter array[{i}]: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Initial array: [" + string.Join(", ", array) + "]");
// Cортировка выбором
for (int i = 0; i < n - 1; i++)
{             //i < n, т.к. последний элемент будет не с чем сравнивать
    int MinIndex = i; //индекс локального min (будет меняться)
    for (int j = i + 1; j < n; j++)
    {   //i = i + 1, чтобы не сравнивать число с самим собой
        //i < n, т.к. последнее число тоже нужно сравнить с min
        if (array[j] < array[MinIndex])
            MinIndex = j; 
            //запоминаем индекс j, чтобы поменять местами элементы
    }
    //перекладывание с помощью вспомогательной переменной temp
    int temp;
    temp = array[MinIndex];
    array[MinIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine(" Sorted array: [" + string.Join(", ", array) + "]");


/*
// СОРТИРОВКА СТРОК (ВЫБОРОМ)
Console.Write("Enter the number of array elements n: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];
//заполнение массива пользователем
for (int i = 0; i < n; i++)
{
    Console.Write($"Enter name {i}: ");
    array[i] = Console.ReadLine();
}

Console.WriteLine();
Console.WriteLine("Initial array: [" + string.Join(", ", array) + "]");
for (int i = 0; i < n - 1; i++)
{
    int minIndex = i;
    for (int j = i + 1; j < n; j++)
    {
        if (array[j].Length < array[minIndex].Length) //сравнение длины строк
            minIndex = j; 
    }
    string temp;
    temp = array[minIndex];
    array[minIndex] = array[i];
    array[i] = temp;
}
Console.WriteLine(" Sorted array: [" + string.Join(", ", array) + "]");
*/