# Задача 2. Найти сумму чисел списка стоящих на нечетной позиции
#           (см. Seminar_3 WorkHome_1.py)

import metods as m


list_numbers = m.set_list_random_numbers(1)  # список рандомных чисел [0, 99] заданного размера

sum_odd_positions = sum([num for i, num in enumerate(list_numbers) if i % 2])  # сумму чисел списка стоящих на нечетной позиции

m.output_response_console(list_numbers, None, sum_odd_positions, 2)  # вывод в консоль
