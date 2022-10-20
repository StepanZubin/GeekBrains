// Дано четное число N (>0) и символы c1 и c2. Написать метод, 
// который вернет строку длины N, которая состоит из 
// чередующихся символов c1 и c2, начиная с c1.

public class task_1 {
    public static void main(String[] args) {
        String c1 = "c1";
        String c2 = "c2";
        int n = 8;
        StringBuilder strN = new StringBuilder();
        for (int i = 0; i < n; i++) {
            if (i % 2 == 0) {
            strN.append(c1);
        } else {
            strN.append(c2);
        }

        }
        System.out.println(strN.toString());
    }  
}
 
// очистка консоли путём поднятия вверх видимой области:
// System.out.print("\033[H\033[2J");
