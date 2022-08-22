import cv2 #подключить библиотеку к коду

#помещаем картинку в переменную
img = cv2.imread('C:/Users/StiKsIIII/Desktop/GeekBrains/Bootcamp_1/13_ExploringOpenCV/test.jpg') 
#print(img)
#print(img.shape)
#img = cv2.resize(img, (500, 500))
#print(img.shape) 
cv2.imshow('Result', img) #вывести картинку на экран

cv2.waitKey(0) #отсрочка закрытия окна с картинкой (при 0 - не закроется никогда)
    #можно указать конкретное время удержания открытым ( в мсек)