// Задача 73. Есть число N. Сколько групп M, можно получить при разбиении 
// всех чисел на группы, так чтобы в одной группе все числа в группе 
// друг на друга не делились? Найдите M при заданном N и получите 
// одно из разбиений на группы N ≤ 10²⁰. 
// Например, для N = 50, M получается 6
// Группа 1: 1
// Группа 2: 2 3 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 7 16 24 36 40
// Группа 6: 5 32 48

// Группа 1: 1
// Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
// Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
// Группа 4: 8 12 18 20 27 28 30 42 44 45 50
// Группа 5: 16 24 36 40
// Группа 6: 32 48

Console.Write("Enter N: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[n];
SetArray(numbers);

int count = 0; //счётчик групп

for (int i = 0; i < numbers.Length; i++) 
{
    if (numbers[i] != 0)
    {
        int[] numbersGroup = new int[numbers.Length];
        int indexGroup = 0; //индекс для массива numbersGroup

        for (int j = i; j < numbers.Length; j++) //проверяем, что не делиться на первое число и записываем в массив numbersGroup
        {
            if (numbers[j] % numbers[i] != 0 || numbers[j] / numbers[i] == 1) 
            {
                numbersGroup[indexGroup] = numbers[j];
                indexGroup++;
            }

        }

        for (int k = 1; k < numbersGroup.Length; k++) //проверяем в получившемся массиве, чтобы числа между собой не делились нацело и обнуляем цифру, кот. делится нацело
        {
            for (int l = k + 1; l < numbersGroup.Length; l++)
            {
                if (numbersGroup[k] != 0 && numbersGroup[l] % numbersGroup[k] == 0) 
                {
                    numbersGroup[l] = 0;
                }
            }
        }

        for (int f = 0; f < numbers.Length; f++)
        {
            for (int m = 0; m < numbersGroup.Length; m++)
            {
                if (numbersGroup[m] == numbers[f]) // обнуляем в основном массиве (numbers) то, что записали в новый (numbersGroup)
                {
                    numbers[f] = 0;
                }
            }
        }

        Console.Write($"Group {++count}: ");
        for (int g = 0; g < numbersGroup.Length; g++) //вывод в консоль групп
        {
            if (numbersGroup[g] != 0) //убираем нулевые значения
            {
                Console.Write(numbersGroup[g] + " ");
            }
        }
        Console.WriteLine();
    }

}

void SetArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = i + 1;
    }
}
