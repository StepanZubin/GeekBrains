# Задача 1. Задайте натуральное число N. Напишите программу, которая составит список простых 
#     множителей числа N.
#     N = 20 -> [2,5]
#     N = 30 -> [2, 3, 5]

from Metod import input_natural_number # Метод ввода из папки: .../Seminar_4/Metod.py

def find_prime_factors_number(num_N):
    '''
    Метод: Создаёт список простых множителей на которые делится, 
            без остатка, заданное натуральное число 
    Аргумент: Натуральное число num_N > 1
    Возвращаемое значение: список простых множителей prime_factors
    '''
    prime_numbers = [] #список последовательности простых чисел [2, num_N]
    for i in range(2, num_N + 1):
        for j in range(2, i):
            if i % j == 0:
                break
        else: 
            prime_numbers.append(i)

    prime_factors = []
    for i in range(len(prime_numbers)):
        if num_N % prime_numbers[i] == 0:
            prime_factors.append(prime_numbers[i])

    return prime_factors


num = input_natural_number('Enter natural number > 1: ')
print('N =', num, '→', find_prime_factors_number(num))

