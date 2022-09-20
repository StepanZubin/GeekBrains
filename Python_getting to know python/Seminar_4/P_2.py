# Задача 2. Задайте два числа. Напишите программу, которая найдет НОК (наименьшее общее кратное) 
#     этих двух чисел. НОК - наименьшее общее кратное, которое делится и на первое, и на второе число.

num_1 = int(input('enter first numbers: '))
num_2 = int(input('enter second numbers: '))

if num_1 > num_2: 
    num_1, num_2 = num_2, num_1
for i in range(1, num_2 + 1):
    if (num_1 * i) % num_2 == 0:
        print('НОК', num_1 * i)
        break
