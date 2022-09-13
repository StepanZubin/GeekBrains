# Задача 1. Напишите программу, которая принимает на вход 
#     вещественное число и показывает сумму его цифр. Учтите, 
#     что числа могут быть отрицательными
#     Пример: 67.82 -> 23
#             0.56 -> 11

def number():
    try: 
        num = float(input('enter N: '))
        return num
    except ValueError:
        print('Incorrect input!')
        return number() 

num_N = str(number())
sum = 0

for i in range(len(num_N)):
    if num_N[i] != '.' and num_N[i] != '-':
        sum += int(num_N[i])
    
print(num_N, '->', sum)





