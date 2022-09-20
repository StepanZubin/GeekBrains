# Задача 2. Задайте последовательность чисел. Напишите программу, которая выведет список 
#     неповторяющихся элементов исходной последовательности. Не использовать множества.
#     [1,1,1,1,2,2,2,3,3,3,4] -> [1,2,3,4]

import itertools # продвинутая генерация списков 
from Metod import input_natural_number # Метод из папки: .../Seminar_4/Metod.py
import random

def set_random_sequence_segments():
    '''
    Метод: Задаёт рандомную последовательность из сегментов (segment_width) 
        содержащих одинаковые числа (number_segment)
    Возвращаемое значение: 
        сеегментарный список чисел sequence_numbers

    '''
    sequence_numbers = []
    sequence_len = input_natural_number('enter size list: ')

    for i in range(sequence_len):
        
        segment_width = random.randint(1, 3) # шширина сегмента
        number_segment = random.randint(1, 9) # число для сегмента
        for j in itertools.repeat(1, segment_width): # генерация повторяющихся чисел
            sequence_numbers.append(number_segment)

    return sequence_numbers

def output_list_different_elements(segment_numbers):
    '''
    Метод: Работает сегментарным списком. Создаёт новый список в котором, 
        в каждом сегменте остаётся только одно число: [1,1,2,2,2,1,1,3,3] → [1,2,1,3]
    Аргумент: Список сегментов содержащих одинаковые числа
    Возвращаемое значение: 
        список сегментов с одним числом elelements
    '''
    elements_one = []
    elements_one.append(segment_numbers[0]) 

    for i in range(len(segment_numbers) - 1):
        if segment_numbers[i] != segment_numbers[i + 1]:
            elements_one.append(segment_numbers[i + 1])
        else:
            continue

    return elements_one

def output_list_unique_numbers(elements_one):
    '''
    Метод: Создаёт список с уникальными числами (на основе заданного списка)
    Аргумент: Список чисел
    Возвращаемое значение: список с уникальными числами
    '''
    numbers_unique = []
    for i in elements_one:
        if i in numbers_unique:
            continue
        numbers_unique.append(i)
    return numbers_unique



list_segment_numbers = set_random_sequence_segments()
print('specified list:   ', list_segment_numbers)

segment_elements_one = (output_list_different_elements(list_segment_numbers))
print('unsegmented list: ', segment_elements_one)

list_unique_numbers = output_list_unique_numbers(segment_elements_one)
print('unique list:      ', list_unique_numbers)











