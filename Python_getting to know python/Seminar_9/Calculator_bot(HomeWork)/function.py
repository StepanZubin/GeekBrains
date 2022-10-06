import user_interface as ui
import calculator as calc
import logger


def calculation_numbers_two(update,context):
    num_1 = ui.input_number() # ввод первого числа
    num_2 = ui.input_number() # ввод второго числа
    action_arithmetic = ui.operation() # ввод арифметического действия

    result = calc.performing_arithmetic_action(num_1, num_2, action_arithmetic) # вычисления
    ui.show_result_console(num_1, num_2, action_arithmetic, result) # вывод результата в консоль

    logger.logger(num_1, action_arithmetic, num_2, result) # запись в файл



def delet_word(update, context):
    text = context.args  # вместо input() → /берёт текст сообщения/
    print(text)
    if not text:
        context.bot.send_messege(update.effective_chat.id, "Привет")
    else:
        string_text = " ".join(map(str,[t for t in text if 'абв' not in t]))
        context.bot.send_message(update.effective_chat.id, string_text)  # вместо вывода информации

def start(update, context):
    arg = context.args
    if not arg:
        context.bot.send_message(update.effective_chat.id, "Привет")
    else:
        context.bot.send_message(update.effective_chat.id, f"{' '.join(arg)}")


def info(update, context):
    context.bot.send_message(update.effective_chat.id,
                             """Доступны следующие команды:
                             /start - эхобот, повторяет всё сказанное через пробел,
                             /info - информация,
                             /delete - удалить абв из строки,
                             /add - добавить задачу""")


def message(update, context):
    text = update.message.text
    if text.lower() == 'привет':
        context.bot.send_message(update.effective_chat.id, 'Привет..')
    else:
        context.bot.send_message(update.effective_chat.id, 'я тебя не понимаю')


def unknown(update, context):
    context.bot.send_message(update.effective_chat.id, f'Я не понимаю(')
    
def give_word(update,context):
    word = update.message.text
    if "бар" in word:
        joke = '''Колобок повесился(.'''
        context.bot.send_message(update.effective_chat.id, joke)
        return joke
    elif "пока" in word:
        context.bot.send_message(update.effective_chat.id, 'ну, пока...')
        return word
    context.bot.send_message(update.effective_chat.id, 'ну, как знать...')


