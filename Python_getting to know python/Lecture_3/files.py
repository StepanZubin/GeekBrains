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


# list = []
# for i in range(1, 21): # список ytчётных чисел [1, 20]
#         list.append(i);
# print(list)
# # тоже самое:
# list = [i for i in range(1, 21)]
# print(list)



# # перечень чётных чисел
# list = [i for i in range(1, 20) if i % 2 == 0]
# print(list) # [2, 4, 6, 8, 10, 12, 14, 16, 18]

# # список кортежей
# list = [(i, i) for i in range(1, 20) if i % 2 == 0]
# print(list) # [(2, 2), (4, 4), (6, 6), (8, 8), (10, 10), (12, 12), (14, 14), (16, 16), (18, 18)]

# # обработка данных
# def f(x):
#         return x**3
# list = [f(i) for i in range(1, 21) if i % 2 == 0]
# print(list) # [8, 64, 216, 512, 1000, 1728, 2744, 4096, 5832, 8000]

# def f(x):
#         return x**3
# list = [(i,f(i)) for i in range(1, 21) if i % 2 == 0]
# print(list) # [(2, 8), (4, 64), (6, 216), (8, 512), (10, 1000), (12, 1728), (14, 2744), (16, 4096), (18, 5832), (20, 8000)]




# Задача
# В файле хранятся числа, нужно выбрать четные и 
# составить список пар (число; квадрат числа). 
# Пример:
# 1 2 3 5 8 15 23 38 (в файле: otus.txt)
# Получить:
# [(2, 4), (8, 64), (38, 1444)]

# path = 'otus.txt' # путь к файлу
# f = open(path, 'r') # открываем файл
# data = f.read() + ' ' # считываем добавляя пробел
# f.close # закрываем файл

# numbers_list = [] # пустой список для наполнения

# while data != '': # заполнение списка numbers_list с проверкой: "пока строка не пустая"
#         space_pos = data.index(' ') # позиция пробела
#         numbers_list.append(int(data[:space_pos])) # берём то что до "пробела" и добавляем в список numbers_list
#         data = data[space_pos + 1:] # "то что выбрали больше не использовать" (обновили строку)

# out = [] # список для чётных значений 
# for e in numbers_list:
#       if not e % 2:
#         out.append((e,e **2)) # добавление кортежей (число, квадрат числа)
# print(out)  # [(2, 4), (8, 64), (38, 1444)]


# # улучшение кода Задачи
# def select(f, col): # принимает функцию и набор данных
#         return [f(x) for x in col] # формируем новый список и возвращаем

# def where(f, col): # принимает функцию и набор данных
#         return [x for x in col if f(x)] # возвращает список

# data = '1 2 3 5 8 15 23 38'.split() # на выходе: набор строк

# res = select(int, data) # преобразование строк в число
# res = where(lambda x: not x % 2, res) # результат работы функции "where" с проверкой чётности чисел c помощью lambda
# print(res) # [2, 8, 38]
# res = select(lambda x: (x, x**2), res) # возвращает кортеж (x, x**2)
# print(res) # [(2, 4), (8, 64), (38, 1444)]



# # Функция map() на замену → select(f, col) из кода выше
# li = [x for x in range(1, 20)] # создаём список
# print(li) # [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19]
# li = list(map(lambda x: x + 10, li)) # преобразование: увеличиваем каждое число на 10
# print(li) # [11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29]


# data = list(map(int, '1 2 3'.split()))
# for e in data:
#         print(e)



# # Функция filter() на замену → where(f, col) из кода выше
# data = [x for x in range(10)] # задан список чисел
# res = list(filter(lambda x: not x % 2, data))
# print(res) #[0, 2, 4, 6, 8]



# # Задача которая была выше с применением map() и filter()
# data = '1 2 3 5 8 15 23 38'.split() # на выходе: набор строк

# res = map(int, data) # преобразование строк в число (вместо select() → map())
# res = filter(lambda x: not x % 2, res) # результат работы функции filter() вьесто where() с проверкой чётности чисел c помощью lambda
# res = list(map(lambda x: (x, x**2), res)) # возвращает кортеж (x, x**2)
# print(res) # [(2, 4), (8, 64), (38, 1444)]



# # Функция zip
# users = ['user1', 'user2', 'user3', 'user4', 'user5'] # набор юзеров
# ids = [4, 5, 9, 14, 7] # набор идентификаторов

# data = list(zip(users, ids)) # [('user1', 4), ('user2', 5), ('user3', 9), ('user4', 14), ('user5', 7)]
# print(data)



# # Функция enumerate()
# users = ['user1', 'user2', 'user3', 'user4', 'user5'] # набор юзеров
# data = list(enumerate(users)) # [(0, 'user1'), (1, 'user2'), (2, 'user3'), (3, 'user4'), (4, 'user5')]
# print(data)












