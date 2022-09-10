# Дз Задача 2. Написать программу для проверки истинности утверждения:  
#      ¬(X ⋁ Y ⋁ Z) = ¬X ⋀ ¬Y ⋀ ¬Z для всех значений предикат. 
#      Предикату можно заменить на понятие “бит”. 
#      Должна получиться таблица истинности. 

for X in [False, True]:
    for Y in [False, True]:
        for Z in [False, True]:
            if not(X or Y or Z) == (not(X) and not(Y) and not(Z)):
                print(X, Y, Z, True)
                
            else:
                print(X, Y, Z, False)

