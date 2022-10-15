// Спросить имя пользователя и поприветствовать с именем.

import java.util.Scanner;
public class task_1 {
    public static void main(String[] args) {
        Scanner iScanner = new Scanner(System.in);
        System.out.printf("name:");  // введите имя
        String name = iScanner.nextLine();  // получение следующей строки
        System.out.printf("Привет, %s!", name);  // вывод в консоль: Привет, (введённое ранее имя)!
        iScanner.close();
    }
}


