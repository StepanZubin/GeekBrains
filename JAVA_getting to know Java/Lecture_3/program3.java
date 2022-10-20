// Object Тип данных
// public class program3 {
//     public static void main(String[] args) {
//         Object o = 1; GetType(o);  // java.lang.Integer
//         o = 1.2; GetType(o);  // java.lang.Double
//     }
//     static void GetType(Object obj) {
//         System.out.println(obj.getClass().getName());
//     }
// }


// Object
// public class program3 {
//     public static void main(String[] args) {
//         System.out.println(Sum(1, 2));      // 3
//         System.out.println(Sum(1.0, 2));    // 0
//         System.out.println(Sum(1, 2.0));    // 0
//         System.out.println(Sum(1.2, 2.1));  // 3.3
//     }
//     static Object Sum(Object a, Object b) {
//         if (a instanceof Double && b instanceof Double) {
//             return (Object)((Double) a + (Double) b);
//         } else if (a instanceof Integer && b instanceof Integer) {
//             return (Object)((Integer) a + (Integer) b);
//         } else return 0;
//     }
// }



// // Массивы (Как увеличить размер массива?)
// //например: (есть массив из 2-х элементов)
// public class program3 {
//     public static void main(String[] args) {
//         int[] a = new int[] {1, 9};
//         int[] b = new int[3];
//         System.arraycopy(a, 0, b, 0, a.length);

//         for (int i : a) {System.out.printf("%d", i);}  // 19
//         System.out.println();
//         for (int j : b) {System.out.printf("%d", j);}  // 190
//     }
// }


// // Массивы
// public class program3 {
//     static int[] AddItem(int[] array, int item) {
//         int length = array.length;
//         int[] temp = new int[length + 1];
//         System.arraycopy(array, 0, temp, 0, length);
//         temp[length] = item;
//         return temp;
//     }
//     public static void main(String[] args) {
//         int[] a = new int[] {0, 9};
//         for (int i : a) {System.out.printf("%d", i);}  // 09
//         a = AddItem(a, 2);
//         a = AddItem(a, 3);
//         System.out.println();
//         for (int j : a) {System.out.printf("%d", j);}  // 0923

//     }
// }



// // Иерархия коллекций. ArrayList
// // "Удобный массив" Разные способы создания
// ArrayList list = new ArrayList(); // не правильное использоввание!
// ArrayList<Integer> list1 = new ArrayList<Integer>();
// ArrayList<Integer> list2 = new ArrayList<>();
// ArrayList<Integer> list3 = new ArrayList<>(10);
// ArrayList<Integer> list4 = new ArrayList<>(list3);



// // Вар.1
// import java.util.ArrayList;
// import java.util.List;

// public class program3 {
//     public static void main(String[] args) {
//         List list = new ArrayList();
//         list.add(2809);
//         list.add("string line");
//         // list.add("string line");  // добавление строк возможно! но не нужно
//         for (Object o : list) {
//             System.out.println(o);  // 2809 → Проблема извлечения данных!
//         }
//     }
// }



// // Вар.2
// import java.util.ArrayList;
// import java.util.List;

// public class program3 {
//     public static void main(String[] args) {
//         ArrayList<Integer> list= new ArrayList<Integer>();
//         list.add(2809);
            // list.add("string line");  // добавление строк невозможно!
//         for (Object o : list) {
//             System.out.println(o);  // 2809 → Нет! Проблемы извлечения данных!
//         }
//     }
// }




// // Коллекции. Save Type ("Сырые типы")
// import java.util.ArrayList;
// import java.util.List;

// public class program3 {
//     public static void main(String[] args) {
//         List<Integer> list = new ArrayList<Integer>();
//         list.add(1);
//         list.add(123);
//         // list.add("string line");  // добавление строк невозможно!
//         for (Object o : list) {
//             System.out.println(o);  // проблема извлечения данных!
//         }
//     }
// }




// // 1 Коллекции. Функционал
// import java.util.ArrayList;
// import java.util.Arrays;
// import java.util.List;

// public class program3 {
//     public static void main(String[] args) {
//         int day = 29;
//         int month = 9;
//         int year = 1990;
//         Integer[] date = {day, month, year};
//         List<Integer> d = Arrays.asList(date);
//         System.out.println(d);  // [29, 9, 1990]
//     }
// }


// // 2 Коллекции. Функционал
// import java.util.ArrayList;
// import java.util.Arrays;
// import java.util.List;

// public class program3 {
//     public static void main(String[] args) {
//         StringBuilder day = new StringBuilder("28");
//         StringBuilder month = new StringBuilder("9");
//         StringBuilder year = new StringBuilder("1990");
//         StringBuilder[] date = new StringBuilder[]{day, month, year};
//         List<StringBuilder> d = Arrays.asList(date);
//         System.out.println(d);  // [29, 9, 1990]
//         date[1] = new StringBuilder("89");
//         System.out.println(d);  // [29, 89, 1990]
//     }
// }



// // 3.1 Коллекции. Функционал
// import java.util.List;

// public class program3 {
//     public static void main(String[] args) {
//         Character value = null;
//         List<Character> list1 = List.of('S', 't', 'e', 'p', 'a', 'n');
//         System.out.println(list1);  // [S, t, e, p, a, n]
//         // list1.remove(1);  // java.lang.UnsupportedOperationException
//         // в коллекции List.of элементы так просто не удаляются!
//         List<Character> list2 = List.copyOf(list1);
//     }
// }


// // 3.2 Коллекции. Функционал
// import java.util.*;

// public class program3 {
//     public static void main(String[] args) {
//         Character value = null;
//         List<Character> list1 = new ArrayList<Character>();
//         list1.add('S');
//         list1.add('t');
//         list1.add('e');
//         list1.add('p');
//         list1.add('a');
//         list1.add('n');
//         System.out.println(list1);  // [S, t, e, p, a, n]
//         list1.remove(5);  // java.lang.UnsupportedOperationException
//         System.out.println(list1);  // [S, t, e, p, a]
//         List<Character> list2 = List.copyOf(list1);
//     }
// }




// // Итератор
// import java.util.*;

// public class program3 {
//     public static void main(String[] args) {
//         List<Integer> list = List.of(1, 12, 123, 1234, 12345);
        
//         for (int item : list) {System.out.println(item);}
//         Iterator<Integer> col = list.iterator();

//         while (col.hasNext()) {
//             System.out.println(col.next());
//             col.next();
//             col.remove();
//         }
//     }
// }


