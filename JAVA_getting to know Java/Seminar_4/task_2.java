// Реализовать консольное приложение, которое: 
// 1. Принимает от пользователя строку вида text~num 
// 1. Нужно рассплитить строку по ~, сохранить text в 
// связный список на позицию num. 
// 2. Если введено print~num, выводит строку из позиции 
// num в связном списке и удаляет её из списка.  
// Пример: ter~1 Jiodf~2 Lsdf~3 

import java.util.Scanner;
import java.util.LinkedList;

public class task_2 {
    public static void main(String[] args) {
        boolean b = false;
        int x = 1;
        LinkedList list=new LinkedList();
        Scanner scanner = new Scanner(System.in);
        while (b == false) {
            System.out.println("введите"+x+ " значение");
            String str1 = scanner.nextLine(); 
            String[] arrstr = str1.split("~");
            list.add(arrstr[0]);

            System.out.println("если хотите выйти введите: 0, иначе любое другое");
            Scanner sanner1 = new Scanner(System.in);
            int y = sanner1.nextInt();
            if (y == 0) {
                b = true;
            }
            x++;
        }
        System.out.println("если хотите вывести значение, введите слово print ");
        Scanner sanner1 = new Scanner(System.in);
        String str2=sanner1.nextLine();
        if (str2.equals("print")) {
            System.out.println("введите номер из списка ");
            Scanner sanner2 = new Scanner(System.in);
            int z=sanner2.nextInt();

            System.out.println(list.get(z-1));
        }
    }
}
