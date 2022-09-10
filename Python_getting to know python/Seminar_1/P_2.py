# Задача 2. Написать программу, которая принимает на вход пять чисел
#     и находит максимальное из них. Например: 78, 55, 36, 90, 23 → 90

first = int(input('enter number 1: '))
second = int(input('enter number 2: '))
third = int(input('enter number 3: '))
fourth = int(input('enter number 4: '))
fifth = int(input('enter number 5: '))

number_max = first
if second >= number_max:
    number_max = second
if third >= number_max:
    number_max = third
if fourth >= number_max:
    number_max = fourth
if fifth >= number_max:
    number_max = fifth

print(first, ', ', second, ', ', third, ', ',
      fourth, ', ', fifth, ' -> ', number_max)


'''
#Решение с семинара
list_number = []
for i in range(5):
    list_number.append (int(input('enter number: ')))

max_number = list_number[0]
for i in range(5):
    if max_number < list_number[i]:
        max_number = list_number[i]

print(max_number)
'''
