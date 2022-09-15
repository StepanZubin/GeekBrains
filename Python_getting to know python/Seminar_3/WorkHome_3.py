# Задача 3. Задайте список из вещественных чисел. Напишите программу, которая 
#     найдёт разницу между максимальным и минимальным значением дробной части 
#     элементов. Пример:
#     [1.1, 1.2, 3.1, 5.17, 10.02] => 0.18 или 18
#     [4.07, 5.1, 8.2444, 6.98] - 0.91 или 91

def number():
    try: 
        num = int(input('enter size list: '))
        return abs(num)
    except ValueError:
        print('Incorrect input!')
        return number()

def set_list_random_numbers(num_elems):
    '''
    Метод: задаёт список вещественных рандомных чисел в интервале [0, 100]
    Аргумент: количество элементов списка
    '''
    import random
    rand_list=[]
    for elem in range(num_elems):
        rand_list.append(random.randint(0, 10**4) / 10**2)
    return rand_list

def max_min_fractional_parts_numbers(numbers_list):
    '''
    Метод: нахождение разницы между максимальным и минимальным значением дробной части элементов
    Аргумент: список вещественных чисел
    Возвращаемые значения: разница между максимальным и минимальным значением дробной части элементов
    '''
    min_part = 1 # элемент списка с нулевой целой частью и минимальной дробной частью 
    max_part = 0 # элемент списка с нулевой целой частью и максимальной дробной частью 

    for elem in range(len(numbers_list)):
        '''
        приведение элементов списка к нулевой целой части и далее нахождение 
        максимального и минимального значений дробных частей элементов списка
        '''
        temp_number = float # временная переменная для хранения элемента с нулевой целой частью
        temp_number = round(float(numbers_list[elem]) - int(numbers_list[elem]), 2)
        
        if temp_number < min_part:
            min_part = temp_number
            
        if temp_number > max_part:
            max_part = temp_number

    return round(max_part - min_part, 2) # возврат искомой разницы
    

size_list = number() # количество элементов в списке
numbers_random = set_list_random_numbers(size_list) # список случайных чисел
print(numbers_random, '→', max_min_fractional_parts_numbers(numbers_random))

