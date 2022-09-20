# def f(x):
#     x**2

# print(type(f))    

# g = f # функцию можно положить в переменную
# print(f(1))
# print(g(1))
# в качестве аргумента функции можно передать функцию




# def f(x):
#     return x**2

# g = f # переменная которая хранит в себе ссылку на функцию

# print(type(f)) # <class 'function'>
# print(type(g)) # <class 'function'>

# print(f(4)) # 16
# print(g(4)) # 16

# print(f(2)) # 4




# def calc(x):
#     return x + 10

# print(calc(10)) # 20

# def calc_2(x):
#     return x * 10

# print(calc_2(10)) # 100




# '''
# в идеале хорошо бы чтобы функция "calc" принимала в качестве аргумента "операцию" 
# и выдfвала результат операции
# '''
# def calc(x):
#     return x + 10

# def calc_2(x):
#     return x * 10

# def math(op, x):
#     print(op(x))

# math(calc, 10) # 20
# math(calc_2, 10) # 100




# # пример с двумя переменными
# def sum(x, y):
#     return x + y

# def mylt(x, y):
#     return x * y

# def calc(op, a, b):
#     print(op(a, b))
#     # return op(a, b)

# calc(mylt, 4, 5) # 20




# # lambda
# sum = lambda x, y: x + y # можно x, y: x + y + 56 и т.д.
#     # тоже самое:
#     # def sum(x, y):
#     #     return x + y

# def calc(op, a, b):
#     print(op(a, b))
#     # return op(a, b)

# calc(sum, 4, 5) # 9

# # вариант 2
# def calc(op, a, b):
#     print(op(a, b))
#     # return op(a, b)

# calc(lambda x, y: x + y, 4, 5) # 9




# List Conprehension (быстро создавать списки)
# list = []
# for i in range(1, 21): # список чётных чисел [1, 20]
#     if i % 2 == 0:
#         list.append(i);
# print(list)


list = []
for i in range(1, 21): # список ytчётных чисел [1, 20]
        list.append(i);
print(list)
# тоже самое:
list = [i for i in range(1, 21)]
print(list)


