# Задача 2. Напишите программу, которая принимает на вход число N 
#     и выдает набор произведений (набор - это список) чисел от 1 до N.
#     Не используйте функцию math.factorial.
#     Пример:
#        пусть N = 4, тогда [ 1, 2, 6, 24 ] (1, 1*2, 1*2*3, 1*2*3*4)

def number():
    try: 
        num = int(input('enter N: '))
        return abs(num)   #на случай ввода отрицательного числа
    except ValueError:
        print('Incorrect input!')
        return number()

num_N = number()

list_factorial = []
num_list = 1
for i in range(1, num_N + 1): #(1*1, 1*2, 2*3, 6*4, 24*...)
    num_list *= i
    list_factorial.append(num_list)

print('N =', num_N,' → ', list_factorial)
