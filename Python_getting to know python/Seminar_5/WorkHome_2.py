# Задача 2. Создайте программу для игры с конфетами человек против человека.
#     Условие задачи: На столе лежит 2021 конфета(или сколько вы зададите). 
#     Играют два игрока делая ход друг после друга. Первый ход определяется жеребьёвкой. 
#     За один ход можно забрать не более чем 28 конфет(или сколько вы зададите). 
#     Тот, кто берет последнюю конфету - проиграл.
#     Предусмотрите последний ход, ибо там конфет остается меньше.
#         a) Добавьте игру против бота
#         b) Подумайте как наделить бота "интеллектом"

import os
import random

def input_number(string): # пропускает только целые числа [1, +Ꝏ]
    try:
        number = int(input(string))
        if number < 1:
            print('Incorrect input!')
            return input_number(string)
        return number
    except ValueError:
        print('Incorrect input!')
        return input_number(string)

def input_data_game(player, num_1, num_2):
    '''
    Метод: Ввод данных для игры с проверкой (2-й игрок, общее количество конфет, количество конфет за ход)
    Аргументы: Три числа
    Возвращаемое значение: 2-й игрок, Общее количество конфет, Количество конфет за ход
    '''
    while player < 2 or player > 3: # Выбор второго игрока: ЧЕЛОВЕК или БОТ
        player = input_number('\nenter opponent number, if HUMAN → "2", if BOT → "3": ')
        if player < 2 or player > 3:
            print('Incorrect input!')

    while num_1 < 10:   # общее кол-во конфет м.б. не меньше 10
        num_1 = input_number('\nenter number candies at least 10: ')
        if num_1 < 10:
            print('Incorrect input!')

    while num_2 < 3 or num_2 > num_1 // 3:   # кол-во конфет за ход м.б. в интервале [3, 30%]
        num_2 = input_number(f'\nenter number candies per turn in interval [3, {num_1 // 3}]: ')
        if num_2 < 3 or num_2 > num_1 // 3:
            print('Incorrect input!')

    return (player, num_1, num_2)

def determining_status_game(num_total, move_1, move_2):
    '''
    Метод: Определение статуса игры и статуса игрока
    Аргументы: Общее количество конфет, Текущий игрок, Следующий игрок
    Возвращаемое значение: Строка статуса игры
    '''
    if num_total == 1:
            print(f'the game is over, player {move_2} has lost')
            return '\nGAME OVER\n'
    elif num_total == 0:
            print(f'the game is over, player {move_1} has lost')
            return '\nGAME OVER\n'
    return ' game continues'

def bot_game(num_total, num_player, num_step):
    '''
    Метод: Бот заменяющий player 2 (рандом + арифметика в концовке игры)
    Аргументы: Общее число конфет(в куче), Число конфет взятые ботом, Число конфет которое можно взять
    Возвращаемое значение: Взятое ботом число конфет
    '''
    if num_total < num_step + 1: 
        num_player = num_step - (num_step - num_total)
        num_player = random.randint(1, num_step)
    print(f'player 2 took candies:  {num_player}')
    return num_player

def input_player_move(num_index_player, num_total, num_player, num_step):
    '''
    Метод: Ввод игроком (включая бота) количества конфет во время хода (с проверкой)
        Изменение общего количества конфет
    Аргументы: Номер игрока, Общее число конфет(в куче), Число конфет введённое игроком, 
        Число конфет которое можно взять
    Возвращаемое значение: Введённое число конфет
    '''
    if num_index_player == 3: # номер бота
            num_player = bot_game(num_total, num_player, num_step)

    if num_index_player == 1 or num_index_player == 2: # игроки 1, 2 (люди)
        while num_player < 1 or num_player > num_step: # количество конфет взятое игроком за ход
            if num_index_player == 1 or num_index_player == 2: # номера людей
                num_player = input_number(f'player {num_index_player} takes candy in interval [1, {num_step}]: ')
                if num_player < 1 or num_player > num_step:
                    print('Incorrect input!')
            
    return num_player

def playing_game(num_total, num_step, opponent):
    '''
    Метод: Игра в конфеты для двух игроков (можно с ботом вместо player 2)
    Аргументы: Общее количество конфет, Количество конфет за ход, Оппонент(человек или бот)
    '''
    while num_total > 1:    # пока конфет больше одной

        if num_total < num_step:   # условие концовки игры
            num_step = num_total   # количество конфет за ход меняется
        print(f'\n total candies {num_total}')
        player_1 = input_player_move(1, num_total, 0, num_step) # ход игрока 1
        num_total -= player_1

        print(determining_status_game(num_total, 1, 2)) # статус игры

        '''
        Для предотвращения выполнения хода player 2 после окончания игры,
        т.к. проверка: num_total > 1 осуществляется после хода player 2
        '''
        if num_total == 0 or num_total == 1: 
            break

        if num_total < num_step:
            num_step = num_total
        print(f'\n total candies {num_total}')
        player_2 = input_player_move(opponent, num_total, 0, num_step) # ход игрока 2
        num_total -= player_2
        
        print(determining_status_game(num_total, 2, 1))

 
os.system('cls')
player, num_candies, num_per_turn = input_data_game(0, 0, 0)
playing_game(num_candies, num_per_turn, player) 




