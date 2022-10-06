
from telegram import Update, Bot
from telegram.ext import Updater, CommandHandler, Filters, MessageHandler, ConversationHandler
from config import TOKEN


bot = Bot(token=TOKEN)
updater = Updater(token=TOKEN)
dispatcher = updater.dispatcher


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

start_handler = CommandHandler('start', start)
info_handler = CommandHandler('info', info)
delete_handler = CommandHandler('delete', delet_word)  # ловец команды delete
message_handler = MessageHandler(Filters.text, give_word)
unknown_handler = MessageHandler(Filters.command, unknown)  # /game


dispatcher.add_handler(start_handler)
dispatcher.add_handler(info_handler)
dispatcher.add_handler(delete_handler)  # привязка ловца команды delete к диспетчеру
dispatcher.add_handler(unknown_handler)
dispatcher.add_handler(message_handler)


print('server started')
updater.start_polling()
updater.idle()




