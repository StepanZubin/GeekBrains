# from isOdd import isOdd

# print(isOdd(0))  # => false
# print(isOdd(4))  # => false



# from progress.bar import Bar
# import time

# bar = Bar('Processing', max=20)
# for i in range(20):
#     time.sleep(0.1) # замедление работы
#     # Do some work
#     bar.next()
# bar.finish()



# import emoji

# print(emoji.emojize('Python is :thumbs_up:'))  # Python is 👍



# import matplotlib.pyplot as plt
# import numpy as np

# list = [1,2,3,2,7]
# plt.plot(list)

# plt.show()



from telegram import Update
from telegram.ext import ApplicationBuilder, CommandHandler, ContextTypes
from bot_commands import *

async def hello(update: Update, context: ContextTypes.DEFAULT_TYPE) -> None:
    await update.message.reply_text(f'Hello {update.effective_user.first_name}')


app = ApplicationBuilder().token("TOKEN").build()

app.add_handler(CommandHandler("hi", hi_command))
app.add_handler(CommandHandler("time", time_command))
app.add_handler(CommandHandler("help", help_command))
# app.add_handler(CommandHandler("sum", sum_command))

print('server start')
app.run_polling()

