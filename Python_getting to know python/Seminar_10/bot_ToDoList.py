import config as c
import logging as l
from telegram import ReplyKeyboardMarkup, ReplyKeyboardRemove, Update
from telegram.ext import Updater, CommandHandler, MessageHandler, Filters,  ConversationHandler

# Включим ведение журнала
l.basicConfig(
    format='%(asctime)s - %(name)s - %(levelname)s - %(message)s', level=l.INFO
)
logger = l.getLogger(__name__)


MAIN_MENU, WORKING_IN_MENU, OUTPUT_LIST = range(3)


def start(update, _):
    reply_keyboard = [['НАЧАТЬ']] 
    markup_key = ReplyKeyboardMarkup(reply_keyboard, resize_keyboard=True, one_time_keyboard=True)
    update.message.reply_text("ToDoList (список дел)"
                            "\n/cancel - выход", reply_markup=markup_key)   
    return MAIN_MENU

def main_menu(update, _):
    reply_keyboard = [['СПИСОК', 'НАЙТИ', 'ДОБАВИТЬ', 'УДАЛИТЬ', 'ВЫЙТИ']] 
    markup_key = ReplyKeyboardMarkup(reply_keyboard, resize_keyboard=True, one_time_keyboard=True)
    update.message.reply_text("выберите действие"
                            "\n/cancel - выход", reply_markup=markup_key)
    return WORKING_IN_MENU

def working_in_menu(update, _):
    user_choice = update.message.text
    if user_choice == "СПИСОК":
        return OUTPUT_LIST
        # elif user_choice == "НАЙТИ":  
        # elif user_choice == "ДОБАВИТЬ": 
        # elif user_choice == "УДАЛИТЬ":     
        # elif user_choice == "ВЫЙТИ":

def output_list(update, _):
    with open('S10_P_ToDo.csv', 'r', encoding='utf-8') as csvfile:
        update.message.reply_text(csvfile.read())

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
            MAIN_MENU: [MessageHandler(Filters.regex('^(НАЧАТЬ)$'), main_menu)],
            WORKING_IN_MENU: [MessageHandler(Filters.regex('^(СПИСОК|НАЙТИ|ДОБАВИТЬ|УДАЛИТЬ|ВЫЙТИ)$'), working_in_menu)],
            OUTPUT_LIST: [MessageHandler(Filters.text, output_list)]
        },
        fallbacks=[CommandHandler('cancel', cancel)]
    )


dispatcher.add_handler(conv_handler)

print('server started')
updater.start_polling()
updater.idle()

