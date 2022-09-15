# Задача 2. Напишите программу, которая найдёт произведение пар чисел списка. 
#     Парой считаем первый и последний элемент, второй и предпоследний и т.д.
#     Пример:
#     [2, 3, 4, 5, 6] => [12, 15, 16];
#     [2, 3, 5, 6] => [12, 15]

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

def product_pairs_list_numbers(list_original):
    '''
    Метод: нахождение произведения пар чисел списка
    Аргумент: список чисел
    Возвращаемое значение: список произведений пар чисел исходного списка
    '''
    
    index_last_elem = -1
    list_final = []
    for elem in range(len(list_original) // 2): 
        '''
        при нечётном кол-ве элементов в списке срединный элемент будет учтён ниже
        '''
        product_num = 1
        product_num *= list_original[elem] * list_original[index_last_elem]

        list_final.append(product_num)

        index_last_elem -= 1
    if len(list_original) % 2 == 1:
        product_num = 1
        product_num *= list_original[len(list_original) // 2] ** 2 
        '''
        при нечётном кол-ве элементов в списке идекс: [len(list_original) // 2]
        будет соответствовать срединному элементу
        '''
        list_final.append(product_num)
    return list_final


size_list = number() # количество элементов в списке
numbers_random = set_list_random_numbers(size_list) # список случайных чисел
print(numbers_random, '→', product_pairs_list_numbers(numbers_random))

