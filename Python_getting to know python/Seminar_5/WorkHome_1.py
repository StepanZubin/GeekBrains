# Задача 1. Напишите программу, удаляющую из текста все слова, содержащие ""абв"".
#     'абвгдейка - это передача' = >" - это передача"

def read_file(file_name):
    '''
    Метод: чтение из файла
    Аргумент: имя файла в директории
    Возвращаемое значение: строка с данными файла
    '''
    with open(file_name, encoding='utf-8') as file:
        file_read = file.read() # чтение в формат <class 'str'>
    return file_read

def write_file(file_name, string_data):
    '''
    Метод: запись в файл
    Аргументы: Имя файла для записи, Строка с данными
    '''
    with open(file_name, 'w', encoding='utf-8') as file:
        file.write(string_data) # запись в формат <class 'str'>


#string_text = 'абвгдейка - это передача'   # вместо чтения из файла
string_text = read_file('file_for_P.S5.WH1.1.txt')   # <class 'str'>
print('original text: ', string_text)
string_text = string_text.split()   # <class 'list'>  

string_edited = [new_text for new_text in string_text if not 'абв' in new_text]   # <class 'list'>
string_edited = ' '.join(string_edited)   # <class 'str'>
print('  edited text: ', string_edited)
string_text = write_file('file_for_P.S5.WH1.2.txt', string_edited)

