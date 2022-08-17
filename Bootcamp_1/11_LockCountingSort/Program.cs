//СОРТИРОВКА ПОДСЧЁТОМ (lock - решение проблемы с "гонкой")
const int THREADS_NUMBER = 4; //определили количество потоков
        //Thread 1 -> [0, 50000);  Thread 2 -> [50000, 100000).  "индексы"
const int N = 100000; //задали размер массива
object locker = new object();

//int[] array = {-10, -5, -9, 0, 2, 5, 1, 3, 1, 0, 1};
//int[] sortedArray = CountingSortExtended(array);
Random rand = new Random(); //создали рандомную переменную
int[] resSerial = new int[N].Select(r => rand.Next(0, 5)).ToArray(); //способ получения массива случайных чисел одной строкой
//resSerial - массив для последовательной сортировки
int[] resParallel = new int[N]; //массив для параллельной сортировки

Array.Copy(resSerial, resParallel, N); //копируем из resSerial, вставляем в resParallel, количество: N элементов

//Console.WriteLine(string.Join(", ", resSerial));

CountingSortExtended(resSerial);
PrepareParallelCountgSort(resParallel);
Console.WriteLine(EqualityMatrix(resSerial, resParallel)); //равны ли наши массивы

//Console.WriteLine(string.Join(", ", resSerial));
//Console.WriteLine(string.Join(", ", resParallel));


void PrepareParallelCountgSort(int[] inputArray) //подготовка параллельных вычислений, создание потоков
{
    int max = inputArray.Max(); //получаем максимальный элемент
    int min = inputArray.Min(); //получаем минимальный элемент

    int offset = -min;
    int[] counters = new int[max + offset + 1]; //обычный массив для количества подсчётов;
                                //потом этот массив будем передавать для различных потоков
    int eachThreadCalc = N / THREADS_NUMBER; //количество вычислений на каждый поток
    var threadsParall = new List<Thread>(); //массив для хранения Thread-ов (List - коллекция, список)

    for (int i = 0; i < THREADS_NUMBER; i++) //запускаем каждый поток в цикле
    {
        int startPos = i * eachThreadCalc;
        int endPos = (i + 1) * eachThreadCalc;
        if (i == THREADS_NUMBER - 1) endPos = N; //кидаем остатки того, что не хватило на endPos
        threadsParall.Add(new Thread(() => CoutingSortParallel(inputArray, counters, offset, startPos, endPos)));
        threadsParall[i].Start(); //запускаем поток
    }

    foreach (var thread in threadsParall) //подождать поток
    {
        thread.Join();
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
}

void CoutingSortParallel(int[] inputArray, int[] counters, int offset, int startPos, int endPos)
{
    
    for (int i = startPos; i < endPos; i++)
    {
        lock (locker) //пока работает один Thread(поток), другой Thread ждёт ("замочек")
        {             //запись ведётся в однопотоке
            counters[inputArray[i] + offset]++; //здесь возникает "гонка"
            //для предотвращения "гонки" делаем lock (синхронизацию записи)
        }
    }
}

void CountingSortExtended(int[] inputArray) //сортировка для последовательного метода
{
    int max = inputArray.Max();
    int min = inputArray.Min();

    int offset = -min;
    int[] counters = new int[max + offset + 1];

    for (int i = 0; i < inputArray.Length; i++)
    {
        counters[inputArray[i] + offset]++;
    }

    int index = 0;
    for (int i = 0; i < counters.Length; i++)
    {
        for (int j = 0; j < counters[i]; j++)
        {
            inputArray[index] = i - offset;
            index++;
        }
    }
}

bool EqualityMatrix(int[] fmatrix, int[] smatrix) //функция сравнения двух массивов
{
    bool res = true;
    for (int i = 0; i < N; i++)
    {
        res = res && (fmatrix[i] == smatrix[i]);
    }
    return res;
}