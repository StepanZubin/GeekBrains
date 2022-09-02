from random  import randint

x=randint(0,100)
count_perebor=0
#метод1 последлвательного перебора:
for i in range(0,101):
    count_perebor+=1
    if i==x:
        print("Число найдено!")
        break

print("Загаданное число:", x, "для поиска потребовалось итераций:", count_perebor, "(методом1) ")


count_random=1
#метод2 случайного отгадывания
y=randint(0,100)
while x!=y:
    y=randint(0,100)
    count_random+=1

print("Загаданное число:", x , "для поиска потребовалось итераций:", count_random, "(методом2) ")

'''
count_bin=1
print('Начнём игру - угадай число от 1 до 100')
#Метод3.1 угадывание вводом пользователя (бинарным способом)
z=int(input('Введите число:'))
while x!=z:
    if x<z: print('загаданное число меньше!')
    else: print('загаданное число больше!')
    z=int(input('Введите число:'))
    count_bin+=1

print("Загаданное число:", z , "для отгадывания потребовалось итераций:", count_bin, "(методом3.1) ")
'''

count_bin=1
print('Начнём игру - угадай число от 1 до 100')
#Метод3.2 угадывание компьютером у компьютера (бинарным способом)
right=100
left=0
mid=(right + left) // 2 #здесь "//" - деление на цело
while x!=mid:
    print(mid)
    if x<mid: 
        print('загаданное число меньше!')
        right=mid-1
    else: 
        print('загаданное число больше!')
        left=mid+1
    mid=(right + left) // 2
    count_bin+=1

print("Загаданное число:", mid , "для отгадывания потребовалось итераций:", count_bin, "(методом3.2) ")
