from fractions import Fraction   # Модуль fractions предоставляет поддержку рациональных чисел

def check_input_fraction(string):
    '''
    Метод: Пользовательский ввод рационального числа в формате a/b;
        Проаверка корректности ввода. 
    Аргумент: Поясняющая строка.
    Возвращаемое значение: Число в формате a/b (<class> 'fractions.Fraction')
        / Класс Fraction() модуля fractions создает рациональное число (простую дробь) /
    '''
    try:
        num_N = Fraction(input(string))
        return(num_N)
    except ValueError:
        print('некорректный ввод!')
        return check_input_fraction(string)
    

def check_input_complex(string):
    '''
    Метод: Пользовательский ввод комплексного числа в формате a+bj;
        Проверка корректности ввода.
    Аргумент: Поясняющая строка.
    Возвращаемое значение: Число в формате a+bj (<class> 'complex').
    '''
    try:
        complex_N = complex(input(string))
        return(complex_N)
    except ValueError:
        print('некорректный ввод!')
        return check_input_complex(string)
        

def check_input_operator(string):
    '''
    Метод: Пользовательский ввод арифметического оператора (+, -, *, /).
        Проверка корректности ввода.
    Аргумент: Поясняющая строка.
    Возвращаемое значение: Арифметический оператор (<class 'str'>).
    '''
    operator = input(string)
    if operator == '+' or operator == '-' or operator == '*' or operator == '/':
        return operator
    else:
        print('некорректный ввод!')
        return check_input_operator(string)


def check_input_type_number(string):
    '''
    Метод: Пользовательский выбор типа вводимого числа (рациональное → 1 или комплексное → 2).
    Аргумент: Поясняющая строка.
    Возвращаемое значение: Число (<class> 'int')
    '''
    try:
        type_number = int(input(string))
        if type_number == 1 or type_number== 2:
            return int(type_number)
        else:
            print('некорректный ввод!')
            return check_input_type_number(string)
    except ValueError:
        print('некорректный ввод!')
        return check_input_type_number(string)
