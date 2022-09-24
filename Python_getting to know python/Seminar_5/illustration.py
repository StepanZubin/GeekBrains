# # список случайных чисел с помощью генератора списка
# import random
# numbers = [random.randint(1, 100) for i in range(5)]
# print(numbers) 


# # функция в лябда-виде
# is_odd = lambda number: False if number % 2 else True 


# # отфильтровать список (оставить только чётные числа)
# import random
# numbers = [random.randint(1, 100) for i in range(5)] # случайный список
# print(numbers) # [32, 74, 27, 37, 47]
# is_odd = lambda number: False if number % 2 else True 
# numbers = list(filter(is_odd, numbers))
# print(numbers) # [32, 74]



# # Сложить элементы (функция zip())
# numbers = [2, 4, 6, 8, 10, 12]
# carbons = [58, 46, 34, 22, 10, 8]
# data_1 = list(zip(numbers, carbons))
# data_2 = []
# for num_1, num_2 in zip(numbers, carbons):
#     data_2.append(num_1 + num_2)
# print(data_1) # [(2, 58), (4, 46), (6, 34), (8, 22), (10, 10), (12, 8)] → в виде списка кортежей
# print(data_2) # [60, 50, 40, 30, 20, 20] → суммы соответствующих элементов



# # Получить список факториалов из списка чисел (функция map())
# from math import factorial
# numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
# factorial = list(map(factorial, numbers))
# print(factorial) # [1, 2, 6, 24, 120, 720, 5040, 40320, 362880, 3628800]



