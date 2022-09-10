# Дз Задача 4. Написать программу, которая по заданному номеру четверти, 
#     показывает диапазон возможных координат точек в этой четверти (X и Y).
# 1-я четверть (x > 0; y > 0), 2-я четверть (x < 0; y > 0), 
# 3-я четверть (x < 0; y < 0), 4-я четверть (x > 0; y < 0).

quarter = int(input('enter number quarter: '))
if quarter < 1 or quarter > 4:
    print('Incorrect input! only 4 quarters')

if quarter == 1:
    print('range of numbers in 1 quarter: (x > 0; y > 0)')
if quarter == 2:
    print('range of numbers in 1 quarter: (x < 0; y > 0)')
if quarter == 3:
    print('range of numbers in 1 quarter: (x < 0; y < 0)')
if quarter == 4:
    print('range of numbers in 1 quarter: (x > 0; y < 0)')