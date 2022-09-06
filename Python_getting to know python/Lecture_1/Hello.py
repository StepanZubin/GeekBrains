'''
print("hello")

# типы данных и переменная
# int, float, boolean, str, None

value = None #просто "value" не получится, нужно присвоить значение
    #None - специальная константа, означающая пустоту
a = 123 #int
b = 1.23 #float
print(a)
print(b)
value = 12334
print(value)
print(type(value)) #узнать тип данных: "type"

s = "hello, world"
print(s)
print(type(s))

print(a, b, s) #интерполяция. вывод трёх переменных
print(a, '-' ,b, '-', s)
print('{} - {} - {}'.format(a, b, s)) #через форматирование
print('{2} - {1} - {0}'.format(a, b, s)) #поменяли порядок вывода 
print(f'{a} - {b} - {s}')

f = True #логическая переменная
print(f)

list = [1, 3, 5] #список
#list = ['1', 'hello'] #список строк
#list = ['1', 'hello', 3, 4, 5.2, False] #в список можно добавлять разные типы данных 
                                        #(но лучше держать в списке данные одного типа)
print(list)
'''



'''
#Ввод и вывод данных
#print, input

print('Enter a: ');
a = float(input()) #можно a = input(), но тогда будет строчная переменная
print('Enter b: ');
b = float(input())
print(a, b)
print('{} {}'.format(a, b))
print(f'{a} {b}')
print(a, '+' , b, ' = ', a+b)
'''



'''
#Арифметические операции
# **, *, /, //, %, +, -
# (), Сокращённые операции
a = 1.3345
b = 3
c = a * b #будет много цифр после запятой (особенность Python)
c = round(a * b) #"round" - округление по математическим правилам
c = round(a * b, 3) #округление до трёх знаков после запятой
print(c)

b *= 3 #операция присваивания
print(b)
'''



'''
#Логические операции
# >, >=, <, <=, ==,!=
# not, and, or - не путать с &, |, ^
# is, is not, in, not in
# gen
a = 1 < 4 and 3 < 2
print(a)

c ="hello"
d = "help"
print(c == d)

c = [1, 3, 5]
d = [3, 4, 2]
print(c != d)

a = 1 < 3 < 4 < 7 < 8
print(a)

f = [1, 2, 3, 4]
print(f)
print(2 in f) #содержится ли 2
print(not 2 in f) #отрицание содержания 2

is_odd = f[0] % 2 == 0 #проверка элемента списка на чётность
# is_odd = not f[0] % 2 #тоже самое (более Python-ский вариант записи)
print(is_odd)
'''



'''
#Управляющие конструкции
# if,  if-else
a = int(input('enter a: '))
b = int(input('enter b: '))
if a < b:
    print(b)
else:
    print(a)

username = input('enter name: ')
if username == 'Masha':
    print('Wow! it is Masha')
elif username == 'Марина':
    print('Я ждала вас, Марина!')
elif username == 'Ильнар': 
    print('Ильнар - молодец!')
else:
    print('Hello, ', username)
'''



'''
#Цикл while
#на примере переворота заданного числа
original = 23
inverted = 0
while original != 0:
    inverted = inverted * 10 + (original % 10)
    original //= 10
    print(original)
else:
        print('Конец')
print(inverted)
'''

'''
#Цикл for
for i in 1, 2, 3, 4, 5: # i - переменная "счётчик"; 
    #после "in" - итерируемый объект (в нашем случае: список)
    print(i**2)

r = range(10) #значения от 0 до 9 (можно указать диапазон: range(2, 10))
    #range(1, 10, 2) - диапазон от 1 до 9 с шагом 2
for i in r:
    print(i)

for i in 'Hello': #работа со строкой
    print(i)
'''



'''
#Функция
from ast import arg


def f(x):
    if x == 1:
        return 'Целое'
    elif x == 2.3:
        return 23
    else:
        return

arg = 1
print(f(arg))
print(type(f(arg)))
'''
