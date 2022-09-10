# Задача 4. Написать программу, которая принимает на вход дробь 
#     и показывает первую цифру дробной части числа. 
#     Например: 6,78 → 7;     5 → no

decimal_number = float(input('enter number: ')) #ввод десятичного числа
integer_number = int(decimal_number) #отделение целой части
remains_number = decimal_number - integer_number #приведение заданного числа к виду: 0,000...
end_number = int(remains_number * 10) #находение 1-й цифры дробной части

if remains_number == 0: #условие на случай ввода пользователем целого числа
    print(int(decimal_number), ' -> no ') 
else:
    print(decimal_number, ' -> ', abs(end_number)) #вывод в консоль (abs - модуль числа)