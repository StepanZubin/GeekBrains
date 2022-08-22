import cv2

face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_frontalface_default.xml") #обратились к библиотеке cv2, чтобы загрузить классификатор

# img = cv2.imread('C:/Users/StiKsIIII/Desktop/GeekBrains/Bootcamp_1/13_ExploringOpenCV/face2.jpg')
# img_gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY) #конвертируем изображение в черно-белое, чтобы было проще с ним работать

# faces = face_cascades.detectMultiScale(img_gray) #найти все лица
# print(faces) #вывод координат рамки

# for (x, y, w, h) in faces: #отображение рамки на картинке
#     cv2.rectangle(img_gray, (x, y), (x + w, y + h), (0, 0, 255), 3)
#     #(x, y) - координаты начала; (x + w, y + h) - координаты конца; (255, 0, 0) - цвет рамки; 3 - толщина

# cv2.imshow('Result', img_gray)

# cv2.waitKey(0)

cap = cv2.VideoCapture(0) #переменная в которой будет держаться соединение с веб-камерой
                    # (0) - номер камеры
while True: #бесконечный цикл для веб-камеры
    souccess, frame = cap.read() #считывание одного кадра
    #success булевая переменная, говорящая удалось ли получить следующий кадр
    #frame - в эту переменную записывается картинка из видео (кадр)
    #cv2.imshow("camera", frame) #вывод картинки
    img_gray = cv2.cvtColor(frame, cv2.COLOR_BGR2GRAY) #конвертируем изображение в черно-белое, чтобы было проще с ним работать
    faces = face_cascades.detectMultiScale(img_gray) #найти все лица

    for (x, y, w, h) in faces: #отображение рамки на картинке
        cv2.rectangle(frame, (x, y), (x + w, y + h), (255, 0, 0), 3)
        #(x, y) - координаты начала; (x + w, y + h) - координаты конца; (255, 0, 0) - цвет рамки; 3 - толщина
        
        cv2.imshow('Result', frame)

    if cv2.waitKey(100) & 0xff == ord('q'): #эта строка позволит выйти из бесконечного цикла, когда назмём: "q"
                # (1) - через 100 мсек будет обновляться кадр
        break
