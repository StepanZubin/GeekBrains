# Задача 6. Сформировать список из N членов последовательности.
# Для N = 5: 1, -3, 9, -27, 81 и т.д (см. Seminar_2 P_1.py)

import metods as m


num_N = abs(m.input_number('введите целое число: '))

list_N = [(-3) ** i for i in range(num_N)]

m.output_response_console(list_N, [], num_N, 6)  # вывод в консоль
