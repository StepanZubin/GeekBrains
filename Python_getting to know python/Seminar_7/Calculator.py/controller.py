import calculator as calc
import user_interface as ui
import logger


def button_click():
    '''
    Метод: Работа проекта "Калькулятор" 
        (Ведение журнала событий (логирование), Запрос данных у пользователя, 
                    Решение арифметической задачи, Вывод результата в консоль).
    '''
    num_1 = ui.input_number() # ввод первого числа
    num_2 = ui.input_number() # ввод второго числа
    action_arithmetic = ui.operation() # ввод арифметического действия

    result = calc.performing_arithmetic_action(num_1, num_2, action_arithmetic) # вычисления
    ui.show_result_console(num_1, num_2, action_arithmetic, result) # вывод результата в консоль

    logger.logger(num_1, action_arithmetic, num_2, result) # запись в файл
