package OOP.Seminar_3;

import java.util.Arrays;
import java.util.Collections;
import java.util.List;

public class Main {
    public static void main(String[] args) {
        User bigBoss = new User("Большой", "Начальник", 50);
        User litleBoss = new User("Маленький", "Начальник", 49);
        //.asList - преобразует массив в список
        List<User> users = Arrays.asList(new User[]{
            new User("Степан", "Зюбин", 42), 
            new User("Пётр", "Георгиев", 90),
            new User("Пётр", "Петров", 22), 
            new User("Герман", "Сидоренко", 86),
            new User("Пётр", "Георгиев", 56)});
        Personal personal = new Personal(users);

        for (User user : personal) {
            System.out.println(user);   
        }
        //сортировка (по возрасту):
        Collections.sort(users);
        System.out.println(users);

        
        Company company = new Company(bigBoss);
        litleBoss.setSubordinates(users);
        bigBoss.setSubordinates(Arrays.asList(litleBoss));
        
        for (User user : company) {
            System.out.println(user);   
        }
    }
}
