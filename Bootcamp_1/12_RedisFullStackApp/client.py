import redis

with redis.Redis() as redis_client:
    value = redis_client.rpop("queue") # извлечь переменные

print(int(value))