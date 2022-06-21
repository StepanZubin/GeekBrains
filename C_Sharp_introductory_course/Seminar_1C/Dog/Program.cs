// "Two friends and a dog"
Console.Clear();
int count = 0,
    friend_speed_1 = 1,
    friend_speed_2 = 2,
    dog_speed = 5,
    time = 0,
    distance = 10000;
bool friend = false;

while (distance > 10)
{
    if (friend = true)
    {
        time = distance / (friend_speed_1 + dog_speed);
        friend = false;
    }
    else
    {
        time = distance / (friend_speed_2 + dog_speed);
        friend = true;
    }
    distance = distance - (friend_speed_1 + friend_speed_2)*time;
    count++;
}

Console.Write("Собака успеет пробежать: " + count+  "раз");
