import random


def get_number(input_string:str)->int:
    '''
    получение числа
    '''
    while True:
        try:
            num = int(input(input_string))
            return num
        except ValueError:
            print('это не то!')


def get_list(num:int)-> list:
    '''
    создаём список
    '''
    list_num = [random.randint(-10, 10) for _ in range(num)]
    return list_num


def write_file(line:str, name:str):
    '''
    запись строк в файл
    '''
    with open(name, 'w', encoding='utf-8') as f:
        f.write(line)


def read_file(name:str)->str:
    '''
    чтение из файла
    '''
    with open(name, 'r', encoding='utf-8') as f:
        data = f.read()
        return data


def remove_spaces_in_string(text):
    '''
    чистка строки (удаление всех пробелов)
    '''
    text = text.replace(' ', '')
    return text


def remove_bracket_in_string(text):
    '''
    удаляет скобки из строки
    '''
    text = text.replace('(', '')
    text = text.replace(')', '')
    return text


def remove_symbols_in_string(text):
    '''
    удаляет заданные символы из строки
    '''
    text = text.replace('+', '')
    text = text.replace('-', '')
    text = text.replace('/', '')
    text = text.replace('*', '')
    text = text.replace('(', '')
    text = text.replace(')', '')
    return text








