# Задача 4. Напишите программу, которая будет преобразовывать 
#     десятичное число в двоичное.
#     Пример:
#     45 -> 101101
#     3 -> 11
#     2 -> 10

def number():
    try: 
        num = int(input('enter binary number: '))
        return abs(num)
    except ValueError:
        print('Incorrect input!')
        return number()

def convert_decimal_to_binary(num):
    '''
    Метод: конвертация десятичного числа в двоичное
    Аргумент: десятичное число
    Возвращаемое значение: двоичное число
    '''
    str_num = ' '
    while num > 0: 
        remains_num = num % 2
        num //= 2
        str_num += str(remains_num)
    str_num = str_num[::-1] # переворот строки при помощи среза
    binary_number = int(str_num) # готовое двоичное число
    return binary_number
    

decimal_number = number() # задать десятичное целое число 
print(decimal_number, '→', convert_decimal_to_binary(decimal_number))


