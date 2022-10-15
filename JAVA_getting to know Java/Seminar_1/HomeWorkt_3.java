// д/з Задача 3. Реализовать простой калькулятор.

import java.util.Scanner;

public class HomeWorkt_3 {

    public static int inputInteger() {
        Scanner sc = new Scanner(System.in); 
        System.out.printf("введите целое число = "); 
        int n = sc.nextInt();
        // sc.close();  // при включении первое обращение к методу работает, а второе - ломает код
        return n;
    }

    public static char inputOperation() {
        Scanner sc = new Scanner(System.in); 
        System.out.printf("введите символ операции (+, -, *, /):  "); 
        char n = sc.next().charAt(0);
        // sc.close();
        return n;
    }

    // только целочисленные операции13
    public static int calculator(int x, int y, char s) {
        int res = 0;
        if (s == '+') {res = x + y;}
        if (s == '-') {res = x - y;}
        if (s == '*') {res = x * y;}
        if (s == '/') {res = x / y;}
        
        return res;
    }

    public static void main(String[] args) {
        
        int num1 = inputInteger();
        char item = inputOperation();
        int num2 = inputInteger();
        int result = calculator(num1, num2, item);
        System.out.println(num1 +" "+ item +" "+ num2 +" "+"= "+ result);
    } 
}
