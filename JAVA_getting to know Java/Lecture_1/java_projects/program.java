/**
 * program
 */

// public class program {

//     public static void main(String[] args) {
//         System.out.println("bye world?!");
//     }
// }



// public class program {

//     public static void main(String[] args) {
//         // String s = "2"; // строковая переменная
//         String s = null; // null - пустая ссылка


//         System.out.println(s);  // 2 либо null
//     }
// }



// public class program {

//     public static void main(String[] args) {
//         short age = 10;
//         int salary = 123456;

//         float e = 2.7f;  // для вещественных значений обязателен суффикс: f
//         double pi = 3.1415;  // можно использовать необязательный суффикс: D

//         char ch = '{';
//         char ch1 = 123;  // 123 - номер чара: {

            
//         System.out.println(age);     // 10
//         System.out.println(salary);  // 123456

//         System.out.println(e);     // 2.7
//         System.out.println(pi);  // 3.1415

//         System.out.println(ch);  // {
//         System.out.println(ch1);  // { т.к 123 - номер чара: {

//     }
// }



// public class program {

//     public static void main(String[] args) {
//         boolean flag1 = 123 <= 234; 
//         System.out.println(flag1);     // true

//         boolean flag2 = 123 >= 234 || flag1;
//         System.out.println(flag2);  // true

//         boolean flag3 = flag1 ^ flag2;
//         System.out.println(flag3);  // false
//     }
// }



// // Неявная типизация
// public class program {
//     public static void main(String[] args) {
//         var a = 123; 
//         System.out.println(a);   // 123 

//         var d = 123.456; 
//         System.out.println(d);   // 123.456

//         //  вызывваем метод getType()
//         System.out.println(getType(a));  // Integer
//         System.out.println(getType(d));  // Double

//         d = 1022;
//         System.out.println(d);  // 1022
//     }
//     // ещё один метод getType() → Статический член класса (обязателен в данной конструкции)
//     static String getType(Object o){
//         return o.getClass().getSimpleName();
//     }
// }
// // любой метод в языке Java должен быть частью класса




// public class program {

//     public static void main(String[] args) {
//         int i = 23_123_34;  // разряды числа можно разделять нижним подчёркиванием (для наглядности)
//         System.out.println(Integer.MAX_VALUE);  // 2147483647
//         System.out.println(Integer.MIN_VALUE);  // -2147483648
//         System.out.println(i);  // 2312334
//     }
// }



// public class program {

//     public static void main(String[] args) {
//         String s = "world";
        
//         System.out.println(s.charAt(2));  // r (нумерация с "0")
//     }
// }



// public class program {

//     public static void main(String[] args) {
//         int a = 123;
        
//         System.out.println(a++);  // 123 (так как приоритет "а", затем "++")
//         // если System.out.println(++а); то → 124
//         // a++ → постфиксный инкремент; ++a → префиксный инкремент
//         System.out.println(a);  // 124
//     }
// }



// // Побитовые сдвиги
// public class program {

//     public static void main(String[] args) {
//         int a = 8;
//         // 8 в двоичной форме → 1000
//         System.out.println(a << 1);  // 16 (сдвиг на 1 бит влево)
//         // 8(1000 + 1бит) → 16(10000)
//     }
// }




// public class program {

//     public static void main(String[] args) {
//         int a = 5;
//         int b = 2;
//         System.out.println(a | b);  // 7 → (a или b)
//         // 101 (5)
//         // 010 (2)
//         // 111 (7) → ("|" - "или") (1 | 0 → 1;   0 | 1 → 1;   1 | 0 → 1)
//     }
// }




// public class program {
//     public static void main(String[] args) {
//         String s = "world";  // длина - 5, индексы - 0...4 
//         boolean b = s.length() >= 6 && s.charAt(5) == '1'; // && - если первое условие false, то второе не проверяется
//                                                                 // & - проверяются оба условия
//         // s.length() - длина строки; s.charAt(5) - пятый символ
//         System.out.println(b);  // false (т.к. '1' нет в "world")
//     }
// }




// // Одномерные массивы
// public class program {
//     public static void main(String[] args) {

//         int[] arr = new int[10];  // можно записать и так: int arr[] 
//         // int[] arr = new int[] {1,2,3} // вариант записи
//         System.out.println(arr.length);  // 10

//         arr = new int[] {1,2,3,4,5};
//         System.out.println(arr.length);  // 5

//         System.out.println(arr[3]);  // 4 (3-й элемент массива)
//     }
// }




// // Многомерные массивы
// public class program {
//     public static void main(String[] args) {

//         int[] arr[] = new int[3][5];  // 3-и строки и 5-ть столбцов (вариант: int[][] arr)
//         for (int[] line : arr) {
//             for (int item : line) {
//                 System.out.printf("%d", item);  //
//             }
//             System.out.println();  //
//         }   
//     }
// }


// Многомерные массивы
// public class program {
//     public static void main(String[] args) {

//         int[][] arr = new int[3][5];  // 3-и строки и 5-ть столбцов (вариант: int[][] arr)
//         for (int i = 0; i < arr.length; i++) {
//             for (int j = 0; j < arr[i].length; j++) {
//                 System.out.printf("%d", arr[i][j]);  //
//             }
//             System.out.println();  //
//         }   
//     }
// }



// ПОЛУЧЕНИЕ ДАННЫХ ИЗ ТЕРМИНАЛА

// // Строки
// import java.util.Scanner;
// public class program {
//     public static void main(String[] args) {
//         Scanner iScanner = new Scanner(System.in);
//         System.out.printf("name: ");  // введите имя
//         String name = iScanner.nextLine();  // получение следующей строки
//         System.out.printf("Привет, %s!", name);  // вывод в консоль: Привет, (введённое ранее имя)!
//         iScanner.close();
//     }
// }

// Некоторые примитивы
import java.util.Scanner;
public class program {
    public static void main(String[] args) {
        Scanner iScanner = new Scanner(System.in); // определили экземляр сканера
        System.out.printf("int a: ");  // ожидаем получение integer-а 
        int x = iScanner.nextInt();
        System.out.printf("double a: ");
        double y = iScanner.nextDouble();
        System.out.printf("%d + %f = %f", x, y, x + y);  // вывод в консоль
        iScanner.close();
    }
}








