# Дз Задача 5. Написать программу, которая принимает координаты двух точек 
#     и находит расстояние между ними в 2D пространстве. 
#     Пример: A(3, 6) B(2, 1) → 5,09;    A(7, -5) B(1, -1) → 7,21 

num_X1 = float(input('enter X1: '))
num_Y1 = float(input('enter Y1: '))
num_X2 = float(input('enter X2: '))
num_Y2 = float(input('enter Y2: '))

num_AB = (num_X2 - num_X1)**2 + (num_Y2 - num_Y1)**2
sqrt = num_AB**(0.5)
print('A(',num_X1, num_Y1,') B(',num_X2, num_Y2,') ->',round(sqrt, 2))

