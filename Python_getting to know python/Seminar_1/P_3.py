# Задача 3. Написать программу, которая принимает на вход 
#     число N  и выводит числа от -N до N

number_N = int(input('enter N: '))
minus_N = -number_N

for i in range(minus_N, number_N + 1):
    print(i)




# #решение с семинара
# num = int(input('enter N: '))

# def show_numbers(n):
#     print([i for i in range(-n, n+1)])

# show_numbers(num)
