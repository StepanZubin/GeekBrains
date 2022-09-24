# Задача 1. Задана натуральная степень n. Сформировать случайным образом список коэффициентов 
#     (значения от 0 до 100) многочлена и записать в файл многочлен степени k.
#     Пример:
#     n = 2 => 2*x² + 4*x + 5 = 0 или x² + 5 = 0 (коэф: []) или 10*x² = 0
#     Уточнения:
#     n - это степень икса первого элемента полинома
#     при n =3 => 5*x*3 + 18*x2 + 7*x + 19 = 0 - коэффициенты = [5,18,7,19]
#     при n=2 => 2*x² + 4*x + 5 = 0(коэф: [2,4,5]) или x² + 5 = 0 (коэф: [1,0,5]) или 10*x²(коэф: [10,0,0]) = 0
#     при n=10 => 56 * x**10 = 0
#     коэффициенты - это числа перед элементами полинома.
#     коэффициенты могут быть нулем, кроме первого

import random

def get_number(input_string: str) -> int:
    '''
    Получение числа
    '''
    while True:
        try:
            num =  int(input(input_string))
            return abs(num)
        except ValueError:
            print('Incorrecr input!')

def write_file(polynoial):
    '''
    Запись многочлена в файл
    '''
    file = open('file_for_P.S5.P1.txt', 'w')
    file.write(polynoial)
    file.close()

def creating_polynomial(number):
    '''
    Создание многочлена (полинома)
    '''
    polinom = ''
    for i in range(number, -1, -1): # цикл в обратную сторону с щагом "-1"
        coef = random.randint(0, 100) # генерирование коэффициентов
        if coef == 1:
            polinom += 'x**' + str(i) + ' + '
        if coef > 1 and i > 1:
            polinom += str(coef) + '*x**' + str(i) + ' + '
        if i == 1:
            polinom += str(coef) + '*x + '
        if i == 0:
            polinom += str(coef) + ' = 0' + '\n'
    return polinom


num_n = get_number('enter n: ')
polinom = creating_polynomial(num_n)
print(polinom)
write_file(polinom)





















