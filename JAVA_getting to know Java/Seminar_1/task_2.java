// Дан массив двоичных чисел, например [1,1,0,1,1,1], 
// вывести максимальное количество подряд идущих 1.

import java.util.Scanner;

public class task_2 {
    public static void main(String[] args) {

        Scanner iScanner = new Scanner(System.in);  // ввод массива с консоли
        System.out.println("enter length array: ");
        int length_array = iScanner.nextInt();
        int[] arr = new int[length_array];
        for (int i = 0; i < arr.length; i++) {
            System.out.printf("enter value number %d of %d:\n", i, length_array);
            arr[i] = iScanner.nextInt();
        }
        iScanner.close();

        System.out.print("заданный массив: ");  // вывод заданного массива в консоль
        for (int i = 0; i < arr.length; i++)
            System.out.print(arr[i]+" ");
        System.out.println();

        int count = 0, max = 0;
        for (int i = 0; i < arr.length; i++) {
            if (arr[i] == 1) {
                count++;
                if (count > max) {
                    max = count;
                }
            } else {
                count = 0;
            }
        }
        
        System.out.printf("максимальное количество идущих подряд 1 -> " + max);
    }
}