# Задача 3. Создайте два списка — один с названиями языков программирования, 
#    другой — с числами от 1 до длины первого: 
#    ['python', 'c#'] и  я[1,2]
#       Cписок кортежей, состоящих из номера и языка, написанного большими буквами:
#    [(1,'PYTHON'), (2,'C#')
#       Отфильтровать список следующим образом: если сумма очков слова имеет 
#    в делителях номер, с которым она в паре в кортеже, то кортеж остается, 
#    его номер заменяется на сумму очков.
#    [сумма очков c# = 102, в делителях есть 2 с которым в паре. Значит список будет]
#    [(482,'PYTHON'), (102,'C#')]

from WorkHome_1 import read_file, write_file

def filtering_list(input_tuples):
    '''
    Метод: Фильтрация списка кортежей
    Аргумент: Список кортежей
    Возвращаемое значение: Новый список кортежей отфильтрованный по условию
    '''
    new_tuples = [] # Новый список кортежей

    for number, name in input_tuples: # Перебор списка кортежей
        sum_number_char = 0 # Сумма чисел символов (по таблице)

        for char in name: # Перебор имени языка в текущем кортеже
            sum_number_char += ord(char) # ord() → номер символа по таблице Unicode
        if sum_number_char % number == 0: 
            '''
            Выполнение условия: если сумма номеров символов текущего имени языка
            делится на цело на соответствующий номер. 
            '''
            new_tuples.append((sum_number_char, name)) # отфильтрованные и изменённые кортежи

    return new_tuples


# список языков программирования:
list_languages = read_file('file_for_P.S5.WH3.1.txt').split()   # <class 'list'>
print('list programming languages: ', list_languages)

# список: числовая последовательность для списка языков программирования
list_number_languages = [i for i in range(1, len(list_languages) + 1)]   # <class 'list'>
print('list numbers:               ', list_number_languages)

# список кортежей (номер + язык заглавными буквами): 
list_languages = list(map(lambda list_languages: list_languages.upper(), list_languages))   # ЗАГЛАВНЫЕ буквы
list_tuples = list(zip(list_number_languages, list_languages))   # <class 'list'>
                    # можно обойтись enumerate(), тогда список чисел будет не нужен
print('list tuples:                ', list_tuples)

filtering_tuples = filtering_list(list_tuples)   # <class 'list'>
print('filtering tuples:           ', filtering_tuples)


# Конверттация списка кортежей в строку и запись в файл:
filtering_string = str(filtering_tuples).strip('[]')   #  <class 'str'>
write_file('file_for_P.S5.WH3.2.txt', filtering_string)

