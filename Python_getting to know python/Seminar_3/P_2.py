# Задача 2. Напишите программу, которая определит позицию второго 
#     вхождения строки в списке либо сообщит, что её нет.
#         Пример:
#     список: ["qwe", "asd", "zxc", "qwe", "ertqwe"], ищем: "qwe", ответ: 3
#     список: [], ищем: "123", ответ: -1

def check_double(list_rows, two_string):
    '''
    Метод: определение позиции второго вхождения строки в списке
    Аргументы: заданный список, заданная строка
    '''
    count = 0
    for row in range(len(list_rows)):
        if two_string == list_rows[row]:
            count += 1
        if count == 2:
            return row
    return False

specified_list = ["qwe", "asd", "zxc", "qwe", "ertqwe"]
specified_string = "qwe"
index_position = check_double(specified_list, specified_string)
if index_position == False:
    print('-1')
else:
    print(index_position)
        



