// д/з Задача 1. Вычислить n-ое треугольное число(сумма чисел от 1 до n), 
//                  n! (произведение чисел от 1 до n).

import java.util.Scanner;

public class HomeWorkt_1 {

    public static int sumToN(int n) {
        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += i;
        return sum;
    }

    public static int productToN(int n) {
        int product = 1;
        for (int i = 2; i <= n; i++)  // i = 2 → операция с i = 1 лишняя
            product *= i;
        return product;
    }

    public static void main(String[] args) {

        Scanner iScanner = new Scanner(System.in); 
        System.out.printf("n = "); 
        int n = iScanner.nextInt();
        iScanner.close();

        int sum_n = sumToN(n);
        System.out.println("сумма чисел от 1 до n: " + sum_n);

        int factorial_n = productToN(n);
        System.out.printf("произведение чисел от 1 до n: " + factorial_n);
    } 
}