// д/з Задача 4*. Задано уравнение вида q + w = e, q, w, e >= 0. 
//      Некоторые цифры могут быть заменены знаком вопроса, 
//      например 2? + ?5 = 69. Требуется восстановить выражение до верного равенства. 
//      Предложить хотя бы одно решение или сообщить, что его нет
//     ! (для двузначных чисел)

import java.util.Scanner;

public class HomeWorkt_4 {

    // public static List parseString(String row) {
        
    // }
 
    public static String inputString(String row) {
        Scanner sc = new Scanner(System.in); 
        System.out.printf("введите "+row+" часть уравнения (q + w = e):  "); 
        String n = sc.next();
        // sc.close();
        return n;
    }

    public static void main(String[] args) {
        String q = inputString("q");
        String w = inputString("w");
        String t = inputString("e");
        // List<Character> parseQ = new ArrayList<>();
        // parseQ = parseString(strQ);
        System.out.println(q);
        System.out.println(w);
        System.out.println(t);


    } 
}
