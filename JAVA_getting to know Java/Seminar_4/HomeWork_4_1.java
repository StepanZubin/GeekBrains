// Пусть дан LinkedList с несколькими элементами. 
// Реализуйте метод, который вернет “перевернутый” список.

import java.util.LinkedList;

public class HomeWork_4_1 {

    public static LinkedList<Integer> reversList (LinkedList<Integer> list) {
        LinkedList<Integer> revList = new LinkedList<Integer>();
        for (int i = 0; i < list.size(); i++) {
            revList.addFirst(list.get(i));
        }
        return revList;
    }
    public static void main (String[] args) {
        LinkedList<Integer> original = new LinkedList<Integer>();
            original.addLast(3);
            original.addLast(2);
            original.addLast(5);
            original.addLast(4);
            original.addLast(8);
            original.addLast(1);
            original.addLast(7);
            original.addLast(1);
        System.out.println("    заданный список: " + original);
        System.out.println("перевёрнутый список: " + reversList(original));
    }
}
