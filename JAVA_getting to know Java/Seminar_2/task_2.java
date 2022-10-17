// Напишите метод, который сжимает строку. Пример: вход aaaabbbcdd.
// Ответ: результат - a4b3cd2 для примера
// aaabbaa → a3b2a2

public class task_2 {
    public static void main(String[] args) {
        String n = "aaaabbbcdd";
        StringBuilder newN = new StringBuilder();
        int count = 1; 
        n = n.concat(" ");
        // System.out.println(n);
        for (int i = 0; i < n.length() - 1; i++) {
            if(n.charAt(i) == n.charAt(i + 1)) {
                count++;
            } else {
                newN.append(n.charAt(i)).append(count);
                count = 1;
            }
        }
        System.out.println(n + "-> " + newN.toString());
    }  
}