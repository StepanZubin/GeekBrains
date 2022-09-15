# Задача 5. Задайте число. Составьте список чисел Фибоначчи, в том числе для 
#     отрицательных индексов.
#     Пример:
#     для n = 8 список будет выглядеть так: 
#     [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

def calculation_fibonacci_number(num_N):
    '''
    Метод: Рекурсивное вычисление n-го числа ряда Фибоначчи
    Аргумент: n-ое число ряда Фибоначчи
    '''
    if num_N in (1,):
        return 0
    if num_N in (2, 3):
        return 1
    else:
        return calculation_fibonacci_number(num_N - 2) + calculation_fibonacci_number(num_N - 1)

def calculation_negafibonacci_number(num_N):
    '''
    Метод: Рекурсивное вычисление n-го числа ряда Негафибоначчи
    Аргумент: n-ое число ряда Негафибоначчи
    '''
    if num_N in (-1,):
        return 1
    if num_N in (-2,):
        return -1
    else:
        return calculation_negafibonacci_number(num_N + 2) - calculation_negafibonacci_number(num_N + 1)

def add_numbers_to_list():
    '''
    Метод: Добавление чисел Негафибоначчи и Фибоначчи в общий список
    Возвращаемое значение: общий список
    '''
    for elem in range(len_negafibonacci_sequence, 0): # ("0" - включён в следующую последовательность)
        negafibonacci_fibonacci.append(calculation_negafibonacci_number(elem))
    for elem in range(1, len_fibonacci_sequence + 2): # ("+2" - с учётом нулевого значения)
        negafibonacci_fibonacci.append(calculation_fibonacci_number(elem))
    return negafibonacci_fibonacci

def number():
    try: 
        num = int(input('enter n: '))
        return abs(num)
    except ValueError:
        print('Incorrect input!')
        return number()


negafibonacci_fibonacci = [] # объединённый список последовательностей чисел Негафибоначчи и Фибоначчи

len_fibonacci_sequence = number() # длина последовательности чисел Фибоначчи
len_negafibonacci_sequence = -len_fibonacci_sequence # длина последовательности чисел Негафибоначчи

print('for n =',len_fibonacci_sequence ,'→', add_numbers_to_list())


