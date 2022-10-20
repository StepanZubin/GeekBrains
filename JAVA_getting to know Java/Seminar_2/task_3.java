// Напишите метод, который составит строку, состоящую из 10 
// повторений слова TEST и метод, который запишет эту строку 
// в простой текстовый файл, обработайте исключения.


import java.io.FileWriter;
import java.io.IOException;

public class task_3 {
    public static String strConcat () {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 10; i++) {
            sb.append("TEST ");
        }
        return sb.toString();
    }  
    public static void writeFile (String inputStrings) {
        
        try {
            FileWriter fw = new FileWriter("J_S2_cw.txt", false);
            // false - перезапись файла, true - дозапись в файл
            fw.append(inputStrings);
            fw.flush();
        } catch (IOException ex) {
            System.out.println(ex.getMessage());
        }
    }
    public static void main (String[] args) {
        String result = strConcat();
        System.out.println(result);
        writeFile(result);
    }
}





// Вариант 2
// package classwork_2;

// import java.io.File;
// import java.io.FileWriter;

// public class task3 {
//     public static void main(String[] args) {
//         // Напишите метод, который составит строку, состоящую из 10 повторений слова
//         // TEST и метод, который запишет эту строку в простой текстовый файл,
//         // обработайте исключения.
//         String test = "TEST";
//         StringBuilder sb = new StringBuilder();
        
//         for (int i = 0; i < 10; i++) {
//             sb.append(test);
//         }
//         String result = sb.toString();
//         try {
//             String pathProject = System.getProperty("user.dir");
//             System.out.println(pathProject);
//             String pathFile = pathProject.concat("/file.txt");
//             File file = new File(pathFile);
//             FileWriter fw = new FileWriter(pathFile);
//             fw.write(result);
//             fw.close();    
//             if (file.createNewFile()) {
//                 System.out.println("file.created");
                
//             } else {
//                 System.out.println("file.existed");
//             }
//         } catch (Exception e) {
//             System.out.println("catch");
//         }
       
//     }
// }
