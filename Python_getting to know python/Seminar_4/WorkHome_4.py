# Задача 4. Шифр Цезаря - это способ шифрования, где каждая буква смещается на определенное 
#     количество символов влево или вправо. При расшифровке происходит обратная операция. 
#         К примеру, слово "абба" можно зашифровать "бввб" - сдвиг на 1 вправо. 
#         "вггв" - сдвиг на 2 вправо, "юяяю" - сдвиг на 2 влево.
#         Сдвиг часто называют ключом шифрования.
#         Ваша задача - написать функцию, которая записывает в файл шифрованный текст, 
#         а также функцию, которая спрашивает ключ, считывает текст и дешифровывает его.

import Metod # импортирование файла с заготовленными методами

def caesar_encryption(text):
    final_text = ''
    for i in text:
        place = alfavit_rus.find(i) # место символа в строке
        new_place = place + step_cipher # новое место символа в строке ( + шаг)
        if i in alfavit_rus:
            final_text += alfavit_rus[new_place] # Задаем новые значения в final_text
        else:
            final_text += i # На случай символов вне заданного Алфавита (остаются без шифрования)
    return final_text

def caesar_decrypted(text):
    final_text = ''
    for i in text:
        place = alfavit_rus.find(i) # место символа в шифре
        new_place = place - step_cipher # возврат на место символа в строке ( - шаг)
        if i in alfavit_rus:
            final_text += alfavit_rus[new_place] # Задаем новые значения в final_text
        else:
            final_text += i # На случай символов вне заданного Алфавита (остаются без дешифрования)
    return final_text


'''
I часть программы: "шифровка"
'''
alfavit_rus = 'АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯАБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ' 
# Алфавит: 2 раза, чтобы шифровать и последние элементы тоже
step_cipher = Metod.input_natural_number_2('enter cipher step [1, 32]: ') # шаг шифрования

# text_original = input('Введите текст на русском языке: ').upper() # текст сообщения пользователя (оригинал)
text_original = Metod.read_file('file_for_WH4.1.txt') # импортированный метод чтения из файла
text_original = " ".join(text_original).upper() # перевод данных из класса "list" в класс "str" 
                                    # .upper() - обращает все символы строки в верхний регистр
encrypted_text = caesar_encryption(text_original) # текст сообщения (зашифрованный)

Metod.write_file('file_for_WH4.2.txt', encrypted_text) # импортированный метод записи в файл

print("original text:  ", text_original)
print('encrypted text: ', encrypted_text)


print(input('press "enter" to decrypt')) # нажмите "enter" для расшифровки 

'''
II часть программы: "дешифровка"
'''
step_cipher_2 = Metod.input_natural_number_2('enter cipher step [1, 32]: ')
encrypted_text_2 = Metod.read_file('file_for_WH4.2.txt')
encrypted_text_2 = " ".join(encrypted_text_2)
decrypted_text = caesar_decrypted(encrypted_text_2)

Metod.write_file('file_for_WH4.3.txt', decrypted_text)

print('encrypted text: ', encrypted_text_2)
print('decrypted_text: ', decrypted_text)

