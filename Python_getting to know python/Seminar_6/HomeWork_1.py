# Задача 1. Определить, присутствует ли в заданном списке строк, 
#        некоторое число (см. Seminar_3 P_1.py)

import metods as m


specified_list = ['gfh5', 'gfh2','67','33', 'jy32','67', '3put']  # заданный список строк
num_desired = m.input_number('введите искомое число (целое): ')

result_list = list(filter(lambda s: str(num_desired) in s, specified_list))  # поиск заданного числа

m.output_response_console(result_list, None, num_desired, 1)  # вывод консоль 
