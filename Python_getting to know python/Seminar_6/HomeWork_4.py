# Задача 4. Определить, позицию второго вхождения строки в списке либо сообщить, 
#         что её нет. (см. Seminar_3 P_2.py)
# Примеры
# список: ["qwe", "asd", "zxc", "qwe", "ertqwe"], ищем: "qwe", ответ: 3
# список: ["йцу", "фыв", "ячс", "цук", "йцукен", "йцу"], ищем: "йцу", ответ: 5
# список: ["йцу", "фыв", "ячс", "цук", "йцукен"], ищем: "йцу", ответ: -1
# список: ["123", "234", 123, "567"], ищем: "123", ответ: -1
# список: [], ищем: "123", ответ: -1

import metods as m


specified_list = ["asd" ,"qwe", "zxc", "ertqwe", "qwe", "qwe"]
string_search = input('введите искомую строку в списке: ')

search_indexes = tuple(i for i, elem in enumerate(specified_list, -1) if elem == string_search)

m.output_response_console(string_search, search_indexes, None, 4)  # вывод в консоль
