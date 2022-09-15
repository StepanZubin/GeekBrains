# Задача 1. Задайте список. Напишите программу, которая определит, 
#     присутствует ли в заданном списке строк некое число.
#     ['gfh5', 'gfh2', '67', 'jy32', '3put'] - ищем 32 - находим по индексу 3

def index_row_with_desired_number(list_strings, number_desired):
    '''
    Метод: индекс_строки_с_искомым_числом. 
    Аргументы: список строк, искомое число.
    Возвращаемое значение: индекс строки с искомым числом, либо False
    Минусы: метод находит все цифры в строке и склеивает (то есть итоговое число может 
            собраться из нескольких чисел строки) Пример: fg7h8 → 78 (пробелы так же
            не учитываются)
    '''
    index_row = 0
    for str_elements in list_strings:
        num = ' '
        for elem in str_elements:
            if elem.isdigit(): # если elem является цифрой
                num = num + elem # составление полного числа из цифр
        if int(num) == number_desired:
            return index_row
        else:
            index_row += 1
    return False
    

specified_list = ['gfh5', 'gfh2', '67', 'jy32', '3put'] # заданный список строк
num_N = 32 # заданное искомое число
index_desired = index_row_with_desired_number(specified_list, num_N) # индекс строки с искомым числом
if index_desired == False:
    print('no number in list')
else:
    print(num_N, 'is in the row with index:', index_desired, '( this line is:', specified_list[index_desired], ')')
    #print(num_N, 'находится в строке с индексом : ', index_desired, 'эта строка: ', specified_list[index_desired])
    





