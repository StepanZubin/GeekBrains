# Задача 4. Реализуйте выдачу случайного числа.
#     не использовать random.randint и вообще библиотеку random
#     Можете использовать xor, биты, библиотеку time или 
#     datetime (миллисекунды или наносекунды) - для задания случайности.
#     Учтите, что есть диапазон: от(минимальное) и до (максимальное)


def random_number_in_given_interval():

    # метод нахождения случайного коэффициента: [0.0, 1.0] (включительно!)
    def random_coefficient(): 
        import datetime 
        dt = datetime.datetime.now()
        time = dt.time()
        microsecond = int(time.strftime('%f')) # %f - микросекунда
        coefficient = round(microsecond / 10**6, 1) # случайный коэффициент (округлённый)
        return coefficient

    # метод ввода (и проверки) целого числа 
    def number(str): 
        try: 
            num = int(input(str))
            return num
        except ValueError:
            print('Incorrect input!')
            return number(str)

    # метод интеграции введённых значений диапазона в список
    def user_input(num = []): 
        num[0] = number("enter first number range: ")
        num[1] = number("enter second number range: ")
        return num[0], num[1]

    # метод проверки и корректировки введённых значений диапазона: [меньшее → бльшее]
    def check_input_numbers(num = []): 
        if num[0] == num[1]:
            print('Incorrect input!')
            user_input(numbers_two)
        elif num[0] > num[1]:
            num[0], num[1] = num[1], num[0]
            return num[0], num[1] 
            

    number_range_1 = int
    number_range_2 = int
    numbers_two = [number_range_1, number_range_2] # предварительный список введённых пользователем чисел

    user_input(numbers_two)
    check_input_numbers(numbers_two)

    # result: случайное целое число из заданного интервала
    result = int(numbers_two[0] + random_coefficient() * (numbers_two[1] - numbers_two[0])) 
    return result, numbers_two
     

print('random number in the range: [ ] →', random_number_in_given_interval())
