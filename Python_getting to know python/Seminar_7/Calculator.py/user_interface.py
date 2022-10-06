from fractions import Fraction
import checking as ch


def rational_number() -> Fraction:
    '''
    Метод: Получение рационального числа от пользователя.
    Возвращаемое значение: Рациональное число в формате a/b (<class 'fractions.Fraction'>)
    '''
    return ch.check_input_fraction('введите рациональное число в формате a/b: ')


def complex_number() -> complex:
    '''
    Метод: Получение комплексного числа от пользователя.
    Возвращаемое значение: Комплексное число в формате a+bj (<class 'complex'>)
    '''
    return ch.check_input_complex('введите комплексное число в формате a+bj: ')


def operation() -> str:
    '''
    Метод: Получение знака арифметической операции от пользователя.
    Возвращаемое значение: Знак арифметической операции +, -, *, / (<class 'str'>)
    '''
    return ch.check_input_operator('введите символ арифметической операции (+, -, *, /): ')


def type_number() -> int:
    '''
    Метод: Получение типа вводимого числа от пользователя (рациональное или комплексное)
    Возвращаемое значение: Число (<class> 'int')
    '''
    return ch.check_input_type_number('выберете тип числа которое собираетесь ввести (1 → рациональное; 2 → комплексное): ')


def show_result_console(num_1, num_2, operator, result):
    '''
    Метод: Вывод результата действия с числами (введёнными пользователем) в консоль.
    Аргументы:
    '''
    print(num_1, operator, num_2, '=', result)


def input_number():
    '''
    Метод: Итоговая функция получения числа от пользователя.
    Возвращаемое значение: Число заданное пользователем. 
    '''
    num_type = type_number()
    if num_type == 1:
        number = rational_number()
    else:
        number = complex_number()
    return number
