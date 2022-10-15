// Принять два числа в консоли и проверить 
// является ли одно квадратом другого

import java.util.Scanner;

public class task_4 {
    public static void main(String[] args) {
        Scanner iScanner = new Scanner(System.in);
        System.out.println("enter number one: ");
        int a = iScanner.nextInt();
        System.out.println("enter number two: ");
        int b = iScanner.nextInt();

        if ((a == b * b) || (b == a * a)) {
            System.out.println("yes");
        } else {
            System.out.println("no");
        }

        iScanner.close();
    }  
}