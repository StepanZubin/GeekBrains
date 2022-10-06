# Задача 5. Найти произведение пар чисел в списке. Парой считаем первый и последний элемент, 
#         второй и предпоследний и т.д. (см. Seminar_3 WorkHome_2.py)
#     Пример:
#     [2, 3, 4, 5, 6] => [12, 15, 16];
#     [2, 3, 5, 6] => [12, 15]

import metods as m


list_num = m.set_list_random_numbers(2)  # список рандомных чисел [-9, 9]

list_result = [list_num[i] * list_num[-1-i] for i in range(len(list_num) // 2 + len(list_num) % 2)]

m.output_response_console(list_num, list_result, None, 5)  # выод в консоль

'''
len(list_num) % 2  → при чётной длине списка == 0, при нечётной длине == 1
(решение вопроса с срединным элементом)
'''
