# Задача 5. Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных. 
#           Входные и выходные данные хранятся в отдельных текстовых файлах.
#     файл первый:
#     AAAAAAAAAAAABBBBBBBBBBBCCCCCCCCCCDDDDDDEEEEEFFFFG python is sooooooo coooooool
#     файл второй:
#     сжатый текст.


import Metod 
import os
os.system('cls')

def data_compression(input_data):
	'''
    # Метод: компрессия (сжатие RLE) текста
	# Аргумент: текстовая строка
	# Возвращаемое значение: строка сжатого текста
    '''
	final_text = '' # сжатая строка

	i = 0
	while i < len(input_data): # перебор всего текста
		count = 1
		# перебор сектора "i" одинаковых элементов:
		while i + 1 < len(input_data) and input_data[i] == input_data[i + 1]:
			count += 1
			i += 1
		# запись подсчитанного числа + сам повторяющийся элемент в итоговую строку:
		final_text += str(count) + input_data[i]
		i += 1
	return final_text

def decompression_data(input_data):
	'''
	Метод: 
	Аргумент:
	Возвращаемое значение:
	'''
	final_text = ''
	count = ''
	
	for char in input_data:
		if char.isdigit():
			count += char
		else:
			final_text += char * int(count)
			count = ''
	return final_text



'''
I часть программы: "компрессия" (сжатие RLE)
'''
original_text = Metod.read_file('file_for_WH5.1.txt') # на выходе list [ ]
original_text = " ".join(original_text) # list конвертирован в str
print('1 part: ')
print('original text from file:   ', original_text)
 
compression_text = data_compression(original_text) # компрессированный текст
Metod.write_file('file_for_WH5.2.txt', compression_text) # запись результата в файл
print('compression text:          ', compression_text)

print()
print(input('press "enter" to decompression')) # нажмите "enter" для декомпрессии 

'''
II часть программы: "декомпрессия" 
'''
compression_text_2 = Metod.read_file('file_for_WH5.2.txt') # на выходе list [ ]
compression_text_2 = " ".join(compression_text_2) # list конвертирован в str
print('2 part: ')
print('compressed text from file: ', compression_text_2)

decompression_text = decompression_data(compression_text_2)
print('decompression text:        ', decompression_text)








