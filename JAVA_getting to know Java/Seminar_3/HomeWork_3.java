// Задача 3. Задан целочисленный список ArrayList. 
//   Найти мин., макс., средн.арифм. значения из этого списка.

import java.util.ArrayList;
import java.util.Random;

public class HomeWork_3 {

    public static ArrayList<Integer> creatingListRandomNumbers() {

        ArrayList<Integer> newArray = new ArrayList<>();

        Random num = new Random();
        for (int i = 0; i < 12; i++) {
            newArray.add(num.nextInt(0, 11));
        }
        return newArray;
    }

    public static int[] searchMinMaxAverage(ArrayList<Integer> list) {
        
        int min = Integer.MAX_VALUE;
        int max = Integer.MIN_VALUE;
        int sum = 0;
        for (int elem : list) {
            if (elem < min) min = elem;
            if (elem > max) max = elem;
            sum += elem;
        } 

        int[] res = new int[3];
        res[0] = min;
        res[1] = max;
        res[2] = sum;

        return res;
    }


    public static void main(String[] args) {

        ArrayList<Integer> list = new ArrayList<>();
        list = creatingListRandomNumbers();
        System.out.println("список чисел: " + list); 

        int[] result = searchMinMaxAverage(list);
        System.out.println(
            "       минимальное число списка: " + result[0] 
            + "\n      максимальное число списка: " + result[1] 
            + "\nсреднее арифметическое значение: " 
            + String.format("%.1f", (double)Math.round(result[2]) / list.size()));
    }
}
