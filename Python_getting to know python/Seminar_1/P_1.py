# Задача 1. Написать программу, которая принимает на вход два числа 
#    и проверяет, является ли одно число квадратом другого
#    Например:  5, 25 → yes

first = int(input('enter number 1: '))
second = int(input('enter number 2: '))
 
if second == first ** 2:
    print(first,', ', second, ' -> yes ')
elif first == second ** 2:
    print(second,', ', first, ' -> yes ')
else:
    print(first,', ', second, ' -> no ')
