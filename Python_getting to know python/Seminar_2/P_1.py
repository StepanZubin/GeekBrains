# Задача 1. Напишите программу, которая принимает на вход число N 
# и выдаёт последовательность из N членов.
#  N = 5: 1, -3, 9, -27, 81

# while True:
#     try: 
#         num_N = int(input('enter N: '))
#     except ValueError:
#         print('Incorrect input!')
#     else: 
#         num_N = abs(num_N) #модуль числа (если вдруг отрицательное ввели)
#         break

# for i in range(num_N):
#     print((-3) ** i, end='   ') #вывод в одну строку






# Метод ввода числа с консоли:
def number():
    try: 
        num = int(input('enter N: '))
        return num
    except ValueError:
        print('Incorrect input!')
        return number() # рекурсия

num_N = abs(number())

for i in range(num_N):
    print((-3) ** i, end='   ')

