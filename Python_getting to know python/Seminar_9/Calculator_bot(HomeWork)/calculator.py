def performing_arithmetic_action(a, b, operator):
    '''
    Метод: Выполнение заданного арифметического действия с двумя заданными числами.
    Аргументы: Первое число, Второе число, Оператор арифметического действия.
    Возвращаемое значение: Число (результат действия).
    '''
    if operator == '+': return a + b
    if operator == '-': return a - b
    if operator == '*': return a * b
    if operator == '/': 
        if b == 0:
            print('на ноль делить нельзя!')
            return False
        return a / b 
    