import redis
import random

# redis_server = redis.Redis() # задаём сервер из подключения к redis
# redis_server.close() # закрываем соединение

with redis.Redis() as redis_server: # with позволяет открыть соединение и закрыть при ошибке
    redis_server.lpush("queue", random.randint(0, 10)) # вставляем в очередь слева