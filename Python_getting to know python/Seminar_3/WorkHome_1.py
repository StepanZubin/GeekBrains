# Задача 1. Задайте список из нескольких чисел. Напишите программу, которая 
#     найдёт сумму элементов списка, стоящих на нечётной позиции.
#     Пример: [2, 3, 5, 9, 3] -> на нечётных позициях элементы 3 и 9, ответ: 12

def number():
    try: 
        num = int(input('enter size list: '))
        return abs(num)
    except ValueError:
        print('Incorrect input!')
        return number()

def set_list_random_numbers(num_elems):
    '''
    Метод: задаёт список натуральных рандомных чисел в интервале [0, 10]
    Аргумент: количество элементов списка
    '''
    import random
    rand_list=[]
    for elem in range(num_elems):
        rand_list.append(random.randint(0, 10))
    return rand_list

def sum_elements_odd_positions(list_numbers):
    '''
    Метод: находит сумму элементов нечётных позиций списка
    Аргумени: список чисел
    Возвращаемое значение: сумма элементов нечётных позиций списка
    '''
    sum_odd = 0
    for elem in range(len(list_numbers)):
        if  elem % 2 != 0:
            sum_odd += list_numbers[elem]
            # print(sum_odd, '+', list_numbers[elem]) # вывод операций сложения
    return sum_odd


size_list = number() # количество элементов в списке
numbers_random = set_list_random_numbers(size_list) # список случайных чисел
print(numbers_random, '→', sum_elements_odd_positions(numbers_random))
