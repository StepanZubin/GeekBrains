# Задача 5. Пользователь вводит время в минутах и 
#     расстояние в километрах. Найти скорость в м/с

from turtle import speed


temp = float(input('enter temp in minutes: '))
distance= float(input('enter distance in kilometers: '))

temp  *= 60
distance *= 1000
speed_meters_second = distance / temp

print(round(speed_meters_second, 1), ' m/s ') #вывод с округлением до 1-го знака после запятой
