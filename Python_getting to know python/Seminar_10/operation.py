from telegram import ReplyKeyboardMarkup
import linecache as lin
import csv
from typing import List


def button_output(update, string):
    reply_keyboard = [['СПИСОК', 'НАЙТИ', 'ДОБАВИТЬ', 'УДАЛИТЬ', 'ВЫЙТИ']] 
    markup_key = ReplyKeyboardMarkup(reply_keyboard, resize_keyboard=True, one_time_keyboard=True)
    update.message.reply_text(string, reply_markup=markup_key)


def for_start_menu(update, _): 
    '''
    Вывод кнопок СТАРТового меню пользователю в телеграмм
    '''
    reply_keyboard = [['НАЧАТЬ', 'ВЫЙТИ']] 
    markup_key = ReplyKeyboardMarkup(reply_keyboard, resize_keyboard=True, one_time_keyboard=True)
    update.message.reply_text("ToDoList (список дел)"
                            "\nвыберите: НАЧАТЬ или ВЫЙТИ", reply_markup=markup_key)


def for_main_menu(update, _):
    '''
    Вывод кнопок ГЛАВного меню пользователю в телеграмм
    '''
    reply_keyboard = [['СПИСОК', 'НАЙТИ', 'ДОБАВИТЬ', 'ВЫЙТИ']] 
    markup_key = ReplyKeyboardMarkup(reply_keyboard, resize_keyboard=True, one_time_keyboard=True)
    update.message.reply_text("выберите действие"
                            "\nСПИСОК, НАЙТИ, ДОБАВИТЬ или ВЫЙТИ", reply_markup=markup_key)

def for_delete_menu(update, _):
    '''
    Вывод кнопок ПОДменю поиск записи
    '''
    reply_keyboard = [['УДАЛИТЬ', 'МЕНЮ']] 
    markup_key = ReplyKeyboardMarkup(reply_keyboard, resize_keyboard=True, one_time_keyboard=True)
    update.message.reply_text("выберите действие"
                            "\nУДАЛИТЬ ЗАПИСЬ или МЕНЮ", reply_markup=markup_key)

def output_list(update, _):  
    '''
    Вывод списка из файла пользователю в телеграмм
    '''
    with open('S10_P_ToDo.csv', 'r', encoding='utf-8') as csvfile:
        update.message.reply_text(csvfile.read())  


def read_csv():
    '''
    Чтение из файла csv с возвращаемым списком
    '''
    with open('S10_P_ToDo.csv','r', encoding='utf-8') as f:
        list_task = [{key: value  for key, value in task.items()}
                for task in csv.DictReader(f, skipinitialspace=True)]
    print(list_task)
    return list_task


def write_csv(list_task: List):
    '''
    Запись новой задачи в файл csv.
    '''
    with open('S10_P_ToDo.csv', 'a', encoding='utf-8') as csvfile:
        writer = csv.writer(csvfile, delimiter= ',')
        writer.writerow(list_task)


   
    