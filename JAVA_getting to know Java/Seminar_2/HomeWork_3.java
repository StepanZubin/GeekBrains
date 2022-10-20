// Задача 3. Напишите метод, который принимает на вход строку (String) 
//     и определяет является ли строка палиндромом (возвращает boolean значение)

import java.util.Scanner;

public class HomeWork_3 {

    public static String gettingString(String comment) {
        Scanner iScanner = new Scanner(System.in, "Cp866");
        // кодировка Cp866 для русских символов
        System.out.print(comment);
        String s = iScanner.nextLine();
        iScanner.close();
        return s;
    }

    public static String reverse(String str)
    {
        int n = str.length();  // длина строки
        char[] charStr = new char[n];  // определяем массив с размером строки
 
        // заполнение массива символами строки (в обратном порядке)
        for (int i = 0; i < n; i++) {
            charStr[n - i - 1] = str.charAt(i);
        }
        return String.copyValueOf(charStr);  // строка из преобразованного массива символов
    }

    public static String stringComparison(String str1, String str2) {
        boolean comparison = str1.equalsIgnoreCase(str2);  // сравнение строк без учета регистра
        if (comparison == true) return (str1 + " -> палиндром");
        else return (str1 + " -> НЕ палиндром");
    }


    public static void main (String[] args) {
        // String startStr = "Город Madam дорог";  // -> палиндром
        // String startStr = "Город Madam";  // -> НЕ палиндром
        String startStr = gettingString("введите строку: ");
        String revStr = reverse(startStr);

        System.out.println(stringComparison(startStr, revStr));
    }
}
