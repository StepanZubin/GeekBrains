
// // 1000000 плюсиков. Время выполнения около 42000 ms (у меня 95456)
// public class program2 {
//     public static void main(String[] args) {
//         var s = System.currentTimeMillis();
//         String str = "";
//         for (int i = 0; i < 1_000_000; i++) {
//             str += "+";
//         }
//         System.out.println(System.currentTimeMillis() - s);
//     }   
// }

// // 1000000 плюсиков. Время выполнения около 9 ms (у меня 11)
// public class program2 {
//     public static void main(String[] args) {
//         var s = System.currentTimeMillis();
//         // String str = "";
//         StringBuilder sb = new StringBuilder();
//         for (int i = 0; i < 1_000_000; i++) {
//             // str += "+";
//             sb.append("+");
//         }
//         System.out.println(System.currentTimeMillis() - s);
//         // System.out.println(str);
//         // System.out.println(st);
//     }   
// }




// // Связь между массивами и строками
// public class program2 {
//     public static void main(String[] args) {
//         String[] name = { "С", "т", "е", "п", "а", "н"};
//         String sk = "СТЕПАН ЗЮБИН";
//         System.out.println(sk.toLowerCase());  // степан зюбин
//         System.out.println(String.join("", name));  // Степан
//         System.out.println(String.join("", "С", "т", "е", "п", "а", "н"));
//         // С,т,е,п,а,н
//         System.out.println(String.join(",", "С", "т", "е", "п", "а", "н"));
//     }   
// }




// // Работа с файлловой системой. Файлы. Ошибки.
// import java.io.File;
// public class program2 {
//     public static void main(String[] args) {
//         try {
//             String pathProject = System.getProperty("user.dir");
//             String pathFile = pathProject.concat("/file.txt");
//             File f3 = new File(pathFile);
//             System.out.println("try");
//         } catch (Exception e) {
//             System.out.println("catch");
//         }
//         finally
//         { System.out.println("finally"); }
//     }  
// }


// import java.io.File;
// public class program2 {
//     public static void main(String[] args) {
//         try {
//             String pathProject = System.getProperty("user.dir");
//             String pathFile = pathProject.concat("/file.txt");
//             File file = new File(pathFile);
//             if (file.createNewFile()) {
//                 System.out.println("file.created");
//             } else {
//                 System.out.println("file.existed");
//             }
//         } catch (Exception e) {
//         System.out.println("catch");
//         } finally {
//         System.out.println("finally");
//         }
//     }
// }


// // // Работа с файлловой системой. Каталоги.
// import java.io.File;
// public class program2 {
//     public static void main(String[] args) {
//             String pathProject = System.getProperty("user.dir");
//             String pathDir = pathProject.concat("/file.txt");
//             File dir = new File(pathDir);
//             System.out.println(dir.getAbsolutePath());
//             if (dir.mkdir()) {
//                 System.out.println("+");
//             } else {
//                 System.out.println("-");
//             }
//             for (String fname : dir.list()) {
//                 System.out.println(fname);
//             }
//    }     
// }
















