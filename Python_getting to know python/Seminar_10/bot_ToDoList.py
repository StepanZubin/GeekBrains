import linecache as lin
import csv
import operation as op
import config as c
import logging as l
from telegram import ReplyKeyboardMarkup, ReplyKeyboardRemove, Update
from telegram.ext import Updater, CommandHandler, MessageHandler, Filters,  ConversationHandler
from datetime import datetime as dt

# Включим ведение журнала
l.basicConfig(
    format='%(asctime)s - %(name)s - %(levelname)s - %(message)s', level=l.INFO
)
logger = l.getLogger(__name__)

TIME_NOW = dt.now().strftime('%D_%H:%M')
MAIN_MENU, WORKING_IN_MENU, TASK_SEARCH, ADD, ADD_TIME_TASK, DELETE_TASK = range(6)


def start(update, _):
    op.for_start_menu(update, _)
    return MAIN_MENU


def main_menu(update, _):
    user_choice = update.message.text
    if user_choice == 'НАЧАТЬ':
        op.for_main_menu(update, _)
    elif user_choice == 'ВЫЙТИ':
        return cancel(update, _)
    return WORKING_IN_MENU


def working_in_menu(update, _):
    user_choice = update.message.text
    
    if user_choice == 'СПИСОК':
        op.output_list(update, _) 
    elif user_choice == "НАЙТИ":
        op.button_output(update, "введите запрос: ")
        return TASK_SEARCH  
    elif user_choice == "ДОБАВИТЬ": 
        op.button_output(update, "введите название задачи(дела): ")
        return ADD

    elif user_choice == "МЕНЮ":  
        op.for_main_menu(update, _) 
        return WORKING_IN_MENU
    elif user_choice == "УДАЛИТЬ":  # недоделано !!!
        update.message.reply_text("ЗАГЛУШКА !!!")
        op.for_main_menu(update, _) 
        return WORKING_IN_MENU

    elif user_choice == "ВЫЙТИ":
        return cancel(update, _)
    return op.for_main_menu(update, _)
  

def add_task(update, context):
    '''
    Считывание названия добавляемой задачи
    '''
    user_task_name = update.message.text
    if user_task_name != 'СПИСОК' and user_task_name != 'НАЙТИ' and user_task_name != 'ДОБАВИТЬ' and user_task_name != 'УДАЛИТЬ' and user_task_name != 'ВЫЙТИ':
        if len(user_task_name) > 2:
            context.user_data['name'] = user_task_name
            op.button_output(update, "введите время для задачи(дела) в формате --:-- ")
            return ADD_TIME_TASK
        else:
            update.message.reply_text('Не менее 3 символов')
            return


def add_time_task(update, context):
    '''
    Считывание времени добавляемой задачи.
    Запись в файл Названия и Времени новой задачи.
    '''
    list_task = []
    user_time_task = update.message.text 
    if user_time_task != 'СПИСОК' and user_time_task != 'НАЙТИ' and user_time_task != 'ДОБАВИТЬ' and user_time_task != 'УДАЛИТЬ' and user_time_task != 'ВЫЙТИ':
        if len(user_time_task) == 5 and user_time_task[2] == ':':
            temp = user_time_task.replace(':', '')
            if temp.isdigit():
                user_task_name = context.user_data.get('name')
                list_task.append(user_task_name.capitalize())
                list_task.append(user_time_task)
                op.write_csv(list_task)
                update.message.reply_text('Задача добавлена')
                op.for_main_menu(update, context)
            else:
                update.message.reply_text("Введите время в формате --:-- ")
                return 
        else:
            update.message.reply_text("Введите время в формате --:-- ")
            return 
    return WORKING_IN_MENU


def task_search(update, _):
    '''
    Поиск и вывод задачи из списка дел
    '''
    user_str = update.message.text

    line = []
    count = 0
    index = 0
    if user_str != 'СПИСОК' and user_str != 'НАЙТИ' and user_str != 'ДОБАВИТЬ' and user_str != 'УДАЛИТЬ' and user_str != 'ВЫЙТИ' and user_str != 'МЕНЮ':
        if len(user_str) == 0:
            update.message.reply_text('вы ввели пустую строку!')
            return task_search()
        elif user_str.isalpha(): 
            context = user_str.title() 
            try:
                open('S10_P_ToDo.csv')
                with open('S10_P_ToDo.csv', encoding='utf-8') as csvfile:
                    file_reader = list(csv.reader(csvfile, delimiter=','))
                    for row in file_reader:
                        if context.capitalize() in row:
                            count += 1
                            line.append(row) 
                            index = file_reader.index(row) 
                    if count == 0: 
                        update.message.reply_text("задача не найдена в списке дел")
                        return op.for_main_menu(update, _)
                    else: 
                        update.message.reply_text(lin.getline('S10_P_ToDo.csv', index + 1))
                        # op.for_delete_menu(update, context) 
                        return op.for_delete_menu(update, context)
            except FileNotFoundError:
                update.message.reply_text("список дел пуст: добавьте запись")
        else: 
            update.message.reply_text('некорректный ввод!')
            return task_search()
    op.for_main_menu(update, _)
    return WORKING_IN_MENU


def cancel(update, _):
    update.message.reply_text(
        'Вы вышли', 
        reply_markup=ReplyKeyboardRemove()  # убрать клавиатуру
    )
    return ConversationHandler.END


if __name__ == '__main__':
   
    updater = Updater(c.TOKEN)
    dispatcher = updater.dispatcher 

    conv_handler = ConversationHandler(

        entry_points=[CommandHandler('start', start), ('cancel', cancel)],
        states={
            MAIN_MENU: [MessageHandler(Filters.regex('^(НАЧАТЬ|ВЫЙТИ)$'), main_menu)],
            WORKING_IN_MENU: [MessageHandler(Filters.regex('^(СПИСОК|НАЙТИ|ДОБАВИТЬ|ВЫЙТИ)$'), working_in_menu)],
            TASK_SEARCH: [MessageHandler(Filters.text, task_search)],
            ADD: [MessageHandler(Filters.text, add_task)],
            ADD_TIME_TASK: [MessageHandler(Filters.text, add_time_task)],
            # DELETE_TASK: [MessageHandler(Filters.text, delete_task)]
        },
        fallbacks=[CommandHandler('cancel', cancel)]
    )


dispatcher.add_handler(conv_handler)

print('server started')
updater.start_polling()
updater.idle()
