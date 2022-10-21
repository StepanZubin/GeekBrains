// Задача 2. Пусть дан произвольный список целых чисел, 
//  удалить из него чётные числа

import java.util.ArrayList;
import java.util.Random;

public class HomeWork_2 {

    public static ArrayList<Integer> creatingListRandomNumbers() {

        ArrayList<Integer> newArray = new ArrayList<>();

        Random num = new Random();
        for (int i = 0; i < 10; i++) {
            newArray.add(num.nextInt(1, 11));
        }
        return newArray;
    }

    public static void main(String[] args) {

        ArrayList<Integer> list = new ArrayList<>();
        list = creatingListRandomNumbers();

        System.out.println("        заданный список: " + list); 
        list.removeIf(i -> i % 2 == 0);
        System.out.println("список без чётных чисел: " + list);
    }
}
