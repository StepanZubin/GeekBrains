import config as c
import logging as l
from telegram import ReplyKeyboardMarkup, ReplyKeyboardRemove, Update
from telegram.ext import Updater, CommandHandler, MessageHandler, Filters,  ConversationHandler

# Включим ведение журнала
l.basicConfig(
    format='%(asctime)s - %(name)s - %(levelname)s - %(message)s', level=l.INFO
)
logger = l.getLogger(__name__)


# = range()


def start(update, _):

    reply_keyboard = [['СПИСОК', 'НАЙТИ', 'ДОБАВИТЬ', 'УДАЛИТЬ', 'ВЫЙТИ']] 
    markup_key = ReplyKeyboardMarkup(reply_keyboard, one_time_keyboard=True)
    update.message.reply_text("ToDoList (список дел)"
                            "\nВыберите действие:", reply_markup=markup_key)
        
    # return 

def cancel(update, _):
    # Отвечаем на отказ поговорить
    update.message.reply_text(
        'Вы вышли', 
        reply_markup=ReplyKeyboardRemove()  # убрать клавиатуру
    )
    # Заканчиваем разговор.
    return ConversationHandler.END






if __name__ == '__main__':
   
    updater = Updater(c.TOKEN)
    dispatcher = updater.dispatcher

    conv_handler = ConversationHandler(
        
        entry_points=[CommandHandler('start', start)],
        states={


        },
        fallbacks=[CommandHandler('cancel', cancel)]
    )


dispatcher.add_handler(conv_handler)

print('server started')
updater.start_polling()
updater.idle()

