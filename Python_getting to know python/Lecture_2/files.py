# #запись данных в файл
# colors = ['red', 'green', 'blue'] #набор данных
# data = open('file.txt', 'a') #создаём текстовую переменную data и связываем её с файлом
#     # 'file.txt' - путь к файлу; 'a' - мод с которым будем работать (a - добавление данных)
# data.writelines(colors) #разделителей не будет
#     #функцинал .writeline позволяет записать некоторый набор данных
# data.close() #после работы с файлом его нухно закрыть (разорвать подключение файловой переменной 
#     #с файлом на диске) для избежания утечек памяти

# #чтение данных из файла
# parh = 'file.txt' #создали путь к файлу
# data = open(parh, 'r') #открыли в режиме чтения ('r' - чтение данных)
# for line in data: #при помощи цикла считаем все строки из файла
#     print(line)
# data.close()




# #использование функционала из файла: hello.py 
#     # (! файл должен быть в той же папке)
# import hello 
# # import hello as h #вар.: чтобы не писать каждый раз "hello"
# print(hello.f(1))
# # print(h.f(1))




# # ФУНКЦИИ
# # def new_string(symol, count): #аргументы: символ и целое число
# #     return symol * count

# # print(new_string('!', 5)) #выдаст в консоль: !!!!!
# # print(new_string('!')) #без аргумента для count выдаст ОШИБКУ

# def new_string(symol, count = 3): #аргументы: символ и целое число
#     return symol * count

# print(new_string('!', 5)) #выдаст в консоль: !!!!! (несмотря на count = 3 в def)
# print(new_string('!')) #выдаст: !!! (т.к. в def -> count задан: 3)
# print(new_string(4)) #выдаст: 12 (т.к. тип данных распознаётся автоматически 
#     # в момент ввызова функции def) 


# def concatenatio(*params):
#     res: str = ""   # int = 0
#     for item in params:
#         res += item
#     return res

# print(concatenatio('a', 's', 'd', 'w'))
# print(concatenatio('a', '1'))
# # print(concatenatio(1, 2, 3, 4)) #вывод: 10




# # РЕКУРСИЯ
# def fib(n):
#     if n in [1, 2]:
#         return 1
#     else:
#         return fib(n-1) + fib(n-2)

# list = []
# for e in range(1, 10):
#     list.append(fib(e))
# print(list) # [1 1 2 3 5 8 13 21 34]





# # СЛОВАРИ
# dictionary = {} #пустой словарь
# dictionary = \
#     {     # "\" - чтобы можно быдо описывать с новой строки
#         'up': '↑', # alt + 24: ↑
#         'left': '←', # alt + 27: ←
#         'down': '↓', # alt + 25: ↓
#         'right': '→' # alt + 26: →
#     }
# print(type(dictionary)) # <class 'dict'>
# print(dictionary) # {'up': '↑', 'left': '←', 'down': '↓', 'right': '→'}
# print(dictionary['left']) # ← (типы ключей могут отличаться)

# for k in dictionary.keys():
#     print(k) #вывод всех ключей: up left down right

# for k in dictionary.values():
#     print(k) #вывод только значений ключей: ↑ ← ↓ →




# # МНОЖЕСТВА
# color = {'red', 'green', 'blue'}
# print(type(color)) # <class 'set'>
# print(color) # {'red', 'green', 'blue'}
# color.add('red') # добавить элемент red в множество
#     # если такой уже есть, то не добавит 
# color.remove('red') # удалить элемент red из множества
#     # ошибка: если такого элемента нет в множестве
# color.discard('red') # удалить элемент без ошибки
# color.clear() # очистить множество

# #Операции со множествами
# a = {1, 2, 3, 5, 8}
# b = {2, 5, 8, 13, 21}
# c = a.copy() # c = {1, 2, 3, 5, 8} копировать
# u = a.union(b) # u = {1, 2, 3, 5, 8, 13, 21} объединить
# i = a.intersection(b) # i = {8, 2, 5} пересечение
# dl = a.difference(b) # dl = {1, 3} разница

# s = frozenset(a) #замороженное неизменяемое множество
#     # добавить и удалить элементы нельзя




# # СПИСКИ
# list1 = [1, 2, 3, 4, 5] # список со значениями
# print(type(list1))
# list2 = list1

# list1[0] = 123 #значение элемента[0] поменяется в обоих списках
# list2[2] = 87 #значение элемента[2] поменяется в обоих списках

# for e in list1:
#     print(e)

# print()

# for e in list2:
#     print(e)

# list1[0] = 123

# print(list1.insert(2, 11)) #вставить 11 после элемента[2]
# print(list1)

# print(list1.append(22)) #вставить 22 в конец
# print(list1)


# print(list1.pop(2)) #удаление элемента[2] из списка
# print(list1)

# print(list1.pop()) #удаление последнего элемента из списка
# print(list1)




