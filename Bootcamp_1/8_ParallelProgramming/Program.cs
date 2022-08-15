/*
1. arr = {1, 0, -6, 2, 5, 3, 2}
2. pivot = arr[6] (опорный элемент)
3. Вызвать шаги 1-2 для подмассивов слева и справа от pivot 
*/

int[] arr = {0, -5, 2, 3, 5, 9, -1, 7};
QuickSort(arr, 0, arr.Length - 1);
Console.Write($"Sorted array: {string.Join(", ", arr)}");

void QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot - 1);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return;
}

int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex - 1;
    for (int i = minIndex; i <= maxIndex; i++)
    {
        if (inputArray[i] < inputArray[maxIndex])
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex);
        }
    }
    pivotIndex++;
    Swap(inputArray, pivotIndex, maxIndex);
    return pivotIndex;
}
// ref - используется ссылка на число, а не копия числа. Напр.: ref int leftValue
// Swap - меняет числа местами
void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int tenp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = tenp;
}