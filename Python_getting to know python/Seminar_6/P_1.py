# Задача 1. Напишите программу вычисления арифметического выражения заданного строкой.
#     Используйте операции +,-,/,. приоритет операций стандартный.
#     Дополнительное задание: Добавьте возможность использования скобок, меняющих приоритет операций
#     *Пример:
#     2+2 => 4;
#     1+2*3 => 7;

#     10/2*5 => 25;
#     10 * 5 * => недостаточно числовых данных
#     -5 + 5 => 0
#     два + три => неправильный ввод: нужны числа
#     (2+((5-3)*(16-14)))/3 => 2
#     (256 - 194 => некорректная запись скобок

from os import system
system('cls')

import func_for_P_1 as fun

def get_str(input_string:str)->str:
    '''
    проверки
    '''
    while True:
        str = input(input_string)  # вводится строка
        str = fun.remove_spaces_in_string(str)  # убираются пробелы из введённой строки
        if str == '':  # проверка на пустую строку
            print('пустая строка!')
            continue
        count_1 = str.count('(')  # подсчёт кол-ва '('
        count_2 = str.count(')')  # подсчёт кол-ва ')'
        if count_1 != count_2:  # проверка парности скобок → ()
            print('некорректная запись скобок!')
            continue

        text = str  # создаётся временная переменная text
        text = fun.remove_symbols_in_string(text)  # из text убираются все символы "операторы" (остаются только числа)
        if not text.isdigit():  # если получившийся text не является числом
            print('некорректный ввод! нужны числа')
            continue
        text = str  # опять создаётся временная переменная text
        text = fun.remove_bracket_in_string(text)  # из text убираются скобки ()
        if not text[0].isdigit() or not text[-1].isdigit():   # если 1-й знак не явл-ся числом и посл-й знак не явл-ся числом ( ? не учтено, что 1-й может быть с "-")
            print('недостаточно числовых данных!')
            continue
        return str


def parse(s: str)-> list:
    result = []
    digit = ''
    for symbol in s:
        if symbol.isdigit():  # если символ число
            digit += symbol   # добавляется в число
        else:
            if digit:  # если в переменной что то есть (???)
                result.append(float(digit))  # добавление к списку чисел
                digit = ''
            result.append(symbol)  # добавление оператора
    if digit:
        result.append(float(digit))
    temp_lst = [y for x, y in zip(result, list(range(len(result)))) if x == '-']  # проверка выхода числа из скобок с минусом: d + (-n)
    for i in temp_lst:
        if type(result[i - 1]) != float:
            temp = result[i + 1]
            result = result[:i] + [temp * -1] + result[i + 2:]  # d] + - [n  →  d] - n
    return result


def calculate(lst: list) -> float:
    '''
    вычисления
    '''
    result = 0.0
    for char in lst:  # 1-й проход по циклу
        if char == '*':
            index = lst.index('*')
            result = lst[index - 1] * lst[index + 1]
            lst = lst[:index - 1] + [result] + lst[index + 2:]
        elif char == '/':
            index = lst.index('/')
            result = lst[index - 1] / lst[index + 1]
            lst = lst[:index - 1] + [result] + lst[index + 2:]
    for char in lst:  # 2-й проход по циклу
        if char == '+':
            index = lst.index('+')
            result = lst[index - 1] * lst[index + 1]
            lst = lst[:index - 1] + [result] + lst[index + 2:]
        elif char == '-':
            index = lst.index('-')
            result = lst[index - 1] - lst[index + 1]
            lst = lst[:index - 1] + [result] + lst[index + 2:]
    return result


def bracket_opening(lst: list) -> list:
    '''
    вычисления в скобках
    '''
    while '(' in lst:
        close = lst.index(')')  # поиск индекса закрытой скобки
        temp_lst = [y for x, y in zip(lst[:close], list(range(close-1))) if x == '(']  # определение соответствующей открытой скобки
        open = temp_lst[-1]
        lst = lst[:open] + [calculate(lst[open + 1: close])] + lst[close + 1]
    return lst


string = get_str('введите выражение:\n')
list_num = parse(string)
list_result = bracket_opening(list_num)
result = calculate(list_result)
print(f'{string} = {result}')

