// Задача 5. Развернуть заданную строку (слова) 

public class task_5 {
    public static void main(String[] args) {
        String str = "Добро пожаловать на курс по Java";
        System.out.println(str);

        String[] words = str.split(" ");
        // метод split() класса String → для разбивки на отдельные слова
        // (передаётся символ разделителя)

        for (int i = words.length - 1; i >= 0; i--) {
            System.out.print(words[i] + " ");
        }
    }
}
