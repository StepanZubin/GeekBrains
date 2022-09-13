# Задача 2. Найти сумму элементов массива, лежащих между 
# максимальным и минимальным по значению элементами
# [1, 8, 16, 3, 5, 9, 4] → 1 + 8 + 16 = 25

# list_number = [1, 8, 16, 3, 5, 9, 4] # index_max_number > index_min_number
# #list_number = [19, 8, 16, 3, 5, 9, 4] # index_min_number > index_max_number
# #list_number = [8, 8, 8, 8, 8, 8, 8] # index_max_number == index_min_number
# index_min_number = list_number.index(min(list_number))
# index_max_number = list_number.index(max(list_number))
# print(list_number[index_min_number], 'end', list_number[index_max_number]) # вывод мин. и макс. числа
# if index_max_number > index_min_number:
#     print(sum(list_number[index_min_number:index_max_number + 1]))
# elif index_min_number > index_max_number:
#     print(sum(list_number[index_max_number:index_min_number + 1]))
# else:
#     print('error: all numbers are equal') #ошибка ввсе числа равны



#Вариант решения 2
def find_sum(arr):
    max_num_index = 0
    min_num_index = 0
    sum = 0
    for i in range(1, len(arr)):
        if arr[i] < arr[min_num_index]:
            min_num_index = i
        if arr[i] > arr[max_num_index]:
            max_num_index = i

    if max_num_index > min_num_index:
        for i in range(min_num_index, max_num_index + 1):
            sum += arr[i]
    else:
        for i in range(max_num_index, min_num_index + 1):
            sum += arr[i]
    return sum

print(find_sum([5, 8, 6, 4, 3, 6]))





