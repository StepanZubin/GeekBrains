// Задача 1. Реализуйте алгоритм сортировки пузырьком числового массива, 
//      результат после каждой итерации запишите в лог-файл.

import java.util.Random;  
import java.util.Scanner;
import java.util.Arrays;
import java.util.logging.*;
import java.io.IOException;


public class HomeWork_1 {

    public static int[] createArrayRandom() {
        Scanner iScanner = new Scanner(System.in);
        System.out.print("enter length array: ");
        int length_array = iScanner.nextInt();
        iScanner.close();

        logger.info("length array: " + length_array);

        int[] arrRandom = new int[length_array];
        int minRange = 10; 
        int maxRange = 99;
        Random num = new Random();

        for (int i = 0; i < length_array; i++) 
            arrRandom[i] = minRange + Math.abs(num.nextInt()) % (maxRange - minRange + 1);
        return arrRandom;
    }

    public static void printArray(int[] arr, String comment) {
        System.out.println(comment + Arrays.toString(arr));
        logger.info(comment + Arrays.toString(arr));
    }

    public static int[] sortArrayBubble(int[] arr) {
        // перебор элементов с конца массива избавляет от дублирующей итерации в конце
        for (int i = arr.length - 1; i > 0; i--) {
            for (int j = 0; j < arr.length - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            
            }
            logger.info((arr.length - i) + "-я итерация;" + "  Результат сортировки: " + Arrays.toString(arr));
        } 
        return arr; 
    }


    public static Logger logger = Logger.getLogger(HomeWork_1.class.getName()); 
    public static void main (String[] args) throws IOException {

        // логирование в файл
        Handler fileHandler = new FileHandler("J_S2_HW1_log.txt"); 
        logger.addHandler(fileHandler);
        SimpleFormatter sFormat = new SimpleFormatter();
        fileHandler.setFormatter(sFormat);

        // int specifiedArr[] = {9,8,7,6,5,4,3,2,1,0};   // ручной ввод массива
        int specifiedArr[] = createArrayRandom(); 
        printArray(specifiedArr, "  not sorted array: ");
        sortArrayBubble(specifiedArr);
        printArray(specifiedArr, "      sorted array: ");      
    }     
}












