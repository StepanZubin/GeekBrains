# Задача 1. Задайте строку из набора чисел. Напишите программу, которая покажет 
#     большее и меньшее число. В качестве символа-разделителя используйте пробел.

string_numbers = input('enter list numbers separated by space: ').split()
list_numbers = list(map(int, string_numbers))
'''
Метод split() делит введённую строку на список подстрок
input('введите список чисел, разделенных пробелом: ').split()
map() выполняет операцию int() для всех элементов списка и возвращает объект map.
list() конвертирует объект map снова в список.
'''
print(string_numbers)
print(list_numbers)
print(max(list_numbers), min(list_numbers))
''' 
если max(string_numbers), min(string_numbers), то 
последний элемент string_numbers не учтётся !!!
'''







