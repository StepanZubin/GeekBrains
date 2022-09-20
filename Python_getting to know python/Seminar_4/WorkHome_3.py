# Задача 3.  В файле, содержащем фамилии студентов и их оценки, изменить на прописные буквы 
#     фамилии тех студентов, которые имеют средний балл более «4».
#                                                                     Пример:
#                                                                 Волков Андрей 5
#                                                                 Наталья Тарасова 5
#                                                                 Фредди Меркури 3
#                                                                 Денис Байцуров 4

#                                                                 Программа выдаст:
#                                                                 ВОЛКОВ АНДРЕЙ 5
#                                                                 НАТАЛЬЯ ТАРАСОВА 5
#                                                                 Фредди Меркури 3
#                                                                 Денис Байцуров 4

def turn_to_int(element):
    '''
    Метод: перевод чисел в списке в класс int
    Аргумент: элемент списка
    Возвращаемое значение: число с классом int
    '''
    if element.isdigit():
        return int(element)
    return element

def read_file(filename):
    '''
    Метод: чтение из файла
    Аргумент: имя файла в директории
    Возвращаемое значение: список с данными файла
    '''
    with open(filename, encoding='utf-8') as file:
        names_read = file.read().split('\n')
    return names_read

def highlight_names(names):
    '''
    Метод: замена на прописные буквы при выполнении условия
    Аргумент: список с данными
    Возвращаемое значение: список списков с изменёнными данными
    '''
    for i, record in enumerate(names):
        record = record.rsplit(' ',maxsplit=1)
        names[i] = list(map(turn_to_int, record))

        if names[i][-1] == 5:
            names[i][0] = record[0].upper()    
    return names

def write_file(filename):
    '''
    Метод: запись в файл
    Аргумент: список списков с изменёнными данными
    '''
    # Конвертация списка списков в список строк    
    filename = [x for l in filename for x in l]
    print(filename)

    with open("tex2.txt", "w", encoding='utf-8') as file:
        print(*filename, file=file, sep="\n")

names = read_file('tex2.txt')    
names = highlight_names(names)
print(names)
write_file(names)







