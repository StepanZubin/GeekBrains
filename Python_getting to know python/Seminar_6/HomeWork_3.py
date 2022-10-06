# Задача 3. Найти расстояние между двумя точками пространства(числа вводятся через пробел)
#       (см. Seminar_1 WorkHome_5.py  →  для 2d пространстве)
#       Пример: A(3, 6) B(2, 1) → 5,1;    A(7, -5) B(1, -1) → 7,2

import metods as m


list_A = m.get_coordinates_point_2d('введите координаты 1-й точки для 2d пространства (два числа через "пробел"!): ')
list_B = m.get_coordinates_point_2d('введите координаты 2-й точки для 2d пространства (два числа через "пробел"!): ')

dist_AB = round(sum([(b - a)**2 for a, b in zip(list_A, list_B)]) **0.5, 1)

m.output_response_console(list_A, list_B, dist_AB, 3)  # вывод в консоль

'''
list(zip(list_A, list_B))   # [(A1, A2), (B1, B2)] <class 'list'> 
    # здесь zip() → создаёт кортежи из списков list_A и list_B
dist = ((B1 - A1)**2 + (B2 - A2)**2) **0.5   # формула расстояния
'''
