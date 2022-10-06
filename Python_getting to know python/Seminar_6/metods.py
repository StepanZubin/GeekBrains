def input_number(string) -> int:
    '''
    Метод: Получение целого числа от пользователя 
        с проверкой корректгости ввода.
    Аргумент: Строка с пояснением пользователю.
    Возвращаемое значение: Целое число.
    '''
    try:
        num = int(input(string))
        return num
    except ValueError:
        print('некорректный ввод!')
        return input_number(string)


def output_response_console(list_1, list_2, num, id):
    '''
    Метод: Вывод ответов задач по числовому id.
    Аргументы: Список 1, Список 2, Числовое значение, Номер задачи.
    '''
    if id == 1:
        if list == []:
            print('такого числа нет с списке строк')
        else:
            print(f'число {num} встречается в заданном списке строк {len(list_1)} раз(а)')

    elif id == 2:
        print(f'для списка: {list_1} сумма элементов с нечётными индексами → {num}')

    elif id == 3:
        print(f'расстояние между точками: A{list_1} и B{list_2} → {num}')

    elif id == 4:
        if len(list_2) > 1:
            print(f"второе вхождение для строки '{list_1}' под индексом: {list_2[1]}")
        elif len(list_2) == 0:
            print(f"строки '{list_1}' нет в заданном списке")
        else:
            print(f'второго вхождения для строки {list_1} нет')

    elif id == 5:
        print(f'для списка: {list_1} произведение пар → {list_2}')

    elif id == 6:
        print(f'для N = {num} список последовательности → {list_1}')


def set_list_random_numbers(id) -> list:
    '''
    Метод: Задаёт список целых рандомных чисел в заданном интервале
        (пользователь задаёт размер списка)
    Возвращаемое значение: Список рандомных чисел.
    '''
    import random

    size_list = abs(input_number('введите размер списка чисел: '))

    if id == 1:
        list_numbers = [random.randint(0, 100) for n in range(size_list)]
        # ls = [x for i in range(n)] → List Comprehensions (генератор списка)
    if id == 2:
        list_numbers = [random.randint(-9, 10) for n in range(size_list)]

    return list_numbers


def get_coordinates_point_2d(string) -> list:
    '''
    Метод: Получение координат точки 2d от пользователя.
    Аргумент: Строка с пояснением пользователю.
    Возвращаемое значение: Список из двух элементов (через пробел).
    '''
    try:
        c = input(string)
        list_coord = list(map(float, c.split(' ')))
        if len(list_coord) < 2 or len(list_coord) > 2:
            print('некорректный ввод!')
            return get_coordinates_point_2d(string)
        return list_coord
    except ValueError:
        print('некорректный ввод!')
        return get_coordinates_point_2d(string)


