// Задача 4*. К калькулятору из предыдущего дз добавить логирование.

import java.util.Scanner;
import java.util.logging.*;
import java.io.IOException;

public class HomeWork_4_dop {

    public static int inputInteger(int num) {
        Scanner sc = new Scanner(System.in); 
        System.out.printf("введите целое число = "); 
        int n = sc.nextInt();

        logger.info("ввод " + num + "-го числа: " + n);
        // sc.close();  // при включении первое обращение к методу работает, а второе - ломает код
        return n;
    }

    public static char inputOperation() {
        Scanner sc = new Scanner(System.in); 
        System.out.printf("введите символ операции (+, -, *, /):  "); 
        char s = sc.next().charAt(0);

        logger.info("ввод символа операции: " + s);
        // sc.close();
        return s;
    }

    // только целочисленные операции
    public static int calculator(int x, int y, char s) {

        int res = 0;
        if (s == '+') {res = x + y;}
        if (s == '-') {res = x - y;}
        if (s == '*') {res = x * y;}
        if (s == '/') {res = x / y;}
        
        logger.info("получение результата: " + res);
        return res;
    }


    public static Logger logger = Logger.getLogger(HomeWork_4_dop.class.getName()); 
    public static void main(String[] args) throws IOException {
        
        // логирование в файл
        Handler fileHandler = new FileHandler("J_S2_HW4_log.txt"); 
        logger.addHandler(fileHandler);
        SimpleFormatter sFormat = new SimpleFormatter();
        fileHandler.setFormatter(sFormat);

        int num1 = inputInteger(1);
        char item = inputOperation();
        int num2 = inputInteger(2);
        int result = calculator(num1, num2, item);

        System.out.println(num1 +" "+ item +" "+ num2 +" "+"= "+ result);
        logger.info("выведено в консоль: " + num1 +" "+ item +" "+ num2 +" "+"= "+ result); 
    } 
}
