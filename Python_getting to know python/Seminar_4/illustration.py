# # вариант 1
# file = open('text.txt', encoding='utf-8')
# print(file.read())
# file.close()

# # вариант 2
# with open('text.txt', encoding='itf-8') as file: # менеджер контекста
#     print(file.read())




# # очистка консоли
# import os
# os.system('cls')



# # к ДомЗадаче №3

# string = 'Восстание Машин 2003'

# # string = string.split(' ') # ['Восстание', 'Машин', '2003']
# # print(string)

# # string = string.split(' ',maxsplit=1) # ['Восстание', 'Машин 2003']
# # print(string)

# string = string.rsplit(' ',maxsplit=1) # ['Восстание Машин', '2003']

# def turn_to_int(element):
#     if element.isdigit():
#         return int(element)
#     return element

# string = list(map(turn_to_int, string)) # ['Восстание Машин', 2003]

# if string[-1] > 4: # ['ВОССТАНИЕ МАШИН', 2003]
#     string[0] = string[0].upper()

# print(string)

# with open('file.txt', encoding='utf-8') as file:
#     names_with_marks = file.read().split('\n')

# print(names_with_marks)





# # Запись в файл
# file = open("otus.txt", 'w', encoding='utf-8')
# file.write("привет rfr ns ")
# file.close()

# # Тоже самое (но файл закрывается автоматически)
# with open('otus.txt', 'w', encoding='utf-8') as file:
#     file.write('пиривеет!')

# my_file = open('otus.txt', 'w', encoding='utf-8')
# my_file.write('Люблю Python! \nЭто крутой язык!') # запись строками: \n
# my_file.close    

# lines = ['one', 'two', 'three']
# with open(r'otus.txt', 'w') as file:
#     for line in lines:
#         file.write(line + '\n')


