# Дз Задача 1. Написать программу, которая принимает на вход цифру, 
#     обозначающую день недели, и проверяет, является ли этот день выходным.
#     Пример:    7 → да;    1 → нет

day_week = input('enter number of day week: ')
if day_week.isdigit() is not True: #проверка: цифра ли в строке
    print('incorrect input!')

day_week = int(day_week)
if day_week == 6 or day_week == 7:
    print(day_week, '-> yes')
elif 1 <= day_week <= 5:
    print(day_week, '-> no')
else:
    print('incorrect input!')

