def input_natural_number(string):
    try:
        num_N = int(input(string))
        if num_N < 2:
            print('Incorrect input! Enter natural number > 1: ')
            return input_natural_number(string)
        return(num_N)
    except ValueError:
        print('Incorrect input! Enter natural number > 1: ')
        return input_natural_number(string)


def input_natural_number_2(string):
    try:
        num_N = int(input(string))
        if num_N < 1 or num_N > 31:
            print('Incorrect input! Enter natural number [1, 32]: ')
            return input_natural_number(string)
        return(num_N)
    except ValueError:
        print('Incorrect input! Enter natural number [1, 32]: ')
        return input_natural_number(string)


def read_file(filename):
    '''
    Метод: чтение из файла
    Аргумент: имя файла в директории
    Возвращаемое значение: список с данными файла
    '''
    with open(filename, encoding='utf-8') as file:
        names_read = file.read().split('\n')
    return names_read


def write_file(filename, text):
    with open(filename, "w", encoding='utf-8') as file:
        file.write(text)
