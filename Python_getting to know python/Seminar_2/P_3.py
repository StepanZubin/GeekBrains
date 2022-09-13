# Задача 3.Найдите количество элементов массива, которые отличны от 
# наибольшего элемента не более чем на 10%

list_number = [1, 8, 10, 3, 5, 9, 4]
max_number = max(list_number) # макс. число
percent_10_number = max_number * 0.1 # 10% от макс. числа

#print(max_number, '→ 10% →', percent_10_number)
count = 0
for i in list_number:
    if i != max_number:
        if max_number - i <= percent_10_number:
            count += 1

print(count)

