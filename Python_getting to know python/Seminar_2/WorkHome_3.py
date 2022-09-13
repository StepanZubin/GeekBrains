# Задача 3. Напишите такую программу, которая найдет 
#     палиндром введенного пользователем числа.
#     (палиндромом называется слово, которое 
#     в обе стороны читается одинаково: "шалаш", "кабак".
#     А еще есть палиндром числа - смысл также в том, 
#     чтобы число в обе стороны читалось одинаково, но есть одно "но".
#     Если перевернутое число не равно исходному, 
#     то они складываются и проверяются на палиндром еще раз.
#     Это происходит до тех пор, пока не будет найден палиндром)

def number():
    try: 
        num = int(input('enter N: '))
        return abs(num)
    except ValueError:
        print('Incorrect input!')
        return number()

def checking_Lychrel_numbers(number): # метод проверки на кандидата в числа Лишрела
    list_Lychrel_number = [
        196, 295, 394, 493, 592, 689, 788, 790, 879, 887, 
        978, 986, 1495, 1297, 1585, 1587, 1675, 1677, 1765, 
        1767, 1855, 1857, 1945, 1947, 1997
        ] 
    result = False
    for i in list_Lychrel_number:
        if number == i:
            print(number, '→ the candidate for the Lychrel numbers')
            result = True
    return result

def invers_numder(number): # метод разворота целого числа
    num_invers = 0
    while number > 0:
        num_end = number % 10 # последняя цифра 1-го числа
        number //= 10 # удаление последней цифры 1-го числа
        num_invers *= 10 # увеличение разрядности 2-го числа
        num_invers += num_end # добавление последней цифры 1-го числа во 2-е
    return num_invers

def find_palindrome(original, reversed): # метод поиска палиндрома
    count_iteration = 0 # счётчик итераций
    while original != reversed:
        original += reversed
        reversed = invers_numder(original) 
        count_iteration += 1
    print('number of iterations:', count_iteration)
    return original
        

num_N = number()
if checking_Lychrel_numbers(num_N) == False:
    num_reversed_N = invers_numder(num_N)
    num_palindrome_N = find_palindrome(num_N, num_reversed_N)
    print('palindrome of the number', num_N, '→', num_palindrome_N)















