# Дз Задача 3. Написать программу, которая принимает на вход координаты точки (X и Y), 
#     причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка. 
#     Пользовательский ввод не должен ломать программу.                                     
#     Пример:     x = 3, y = -8 → 4 четверть
# 1-я четверть (x > 0; y > 0), 2-я четверть (x < 0; y > 0), 
# 3-я четверть (x < 0; y < 0), 4-я четверть (x > 0; y < 0).

num_X = int(input('enter X: '))
num_Y = int(input('enter Y: '))

if num_X == 0 or num_Y == 0:
    print('Incorrect input! -> X != 0 and Y !=0')

if num_X > 0 and num_Y > 0:
    print('x =',num_X,',', 'y =',num_Y,'-> 1 quarter')
if num_X < 0 and num_Y > 0:
    print('x =',num_X,',', 'y =',num_Y,'-> 2 quarter')
if num_X < 0 and num_Y < 0:
    print('x =',num_X,',', 'y =',num_Y,'-> 3 quarter')
if num_X > 0 and num_Y < 0:
    print('x =',num_X,',', 'y =',num_Y,'-> 4 quarter')