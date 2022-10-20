// Заполнить список десятью случайными числами. 
// Отсортировать список методом sort() и вывести его на экран.

import java.util.ArrayList;
import java.util.Comparator;
import java.util.Random;


public class task_2 { 
    public static void main(String[] args) {

        ArrayList<Integer> list = new ArrayList<>();
        
        Random rnd = new Random();
        for (int i = 0; i < 10; i++) {
            list.add(rnd.nextInt(1, 11));
        }
        System.out.println(list);

        list.sort(Comparator.naturalOrder());
        System.out.println(list);

    }
}
