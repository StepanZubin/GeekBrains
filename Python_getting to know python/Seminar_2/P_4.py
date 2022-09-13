# Сортировка пузырьком

list_number = [1, 8, 16, 3, 5, 9, 4]

for i in range(len(list_number) - 1):
    for j in range(len(list_number) - i - 1):
        if list_number[j] > list_number[j + 1]:
           # Python. Поменять элементы местами: a, b = b, a
           # list_number[j], list_number[j + 1] = list_number[j + 1], list_number[j] # вариант для списка
           temp = list_number[j]
           list_number[j] = list_number[j + 1]
           list_number[j + 1] = temp

print(list_number)
