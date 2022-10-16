//  д/з Задача 2. Вывести все простые числа от 1 до 1000.

import java.time.Instant;
import java.time.Duration;

import java.util.Scanner;
 
public class HomeWorkt_2 {

    public static void searchPrimeNumbersToN(int n) {
        for(int i = 2; i <= n; i++) {
            boolean numberPrime = true;
            for(int j = 2; j < i; j++) {
                if(i % j == 0) {
                    numberPrime = false;
                    break;
                } 
            }
            if (numberPrime == true) {
                System.out.print(i + " ");
            }
        }     
    }

    public static void main(String[] args) {

        Instant start = Instant.now();  // время начала запуска кода

        Scanner iScanner = new Scanner(System.in); 
        System.out.printf("n = "); 
        int n = iScanner.nextInt();
        iScanner.close();

        searchPrimeNumbersToN(n);

        Instant finish = Instant.now();  // время окончания работы кода
        long elapsed = Duration.between(start, finish).toMillis();  // пройденное время работы кода

        System.out.println();
        System.out.println("Время работы кода: " + elapsed + " (ms)"); // заметна погрешность
    } 
}
