// Создать список типа ArrayList
// Поместить в него как строки, так и целые числа. 
// Пройти по списку, найти и удалить целые числа

import java.util.ArrayList;
// import java.util.


public class task_4 {
    
    public static void main(String[] args) {

        ArrayList array = new ArrayList<> ();

        array.add(1);
        array.add("строка");
        array.add("значение");
        array.add(45);
        array.add("string");
        array.add(7);
        array.add(7);
        array.add(7);

        System.out.println(array);
        for (int i = 0; i < array.size(); i++) {
            if (array.get(i) instanceof Integer) {
                array.remove(i);
                i--; // так как список динамический -> индекс смещается при удалении
                // (если идти циклом в обр.сторону то i-- не надо делать)
            }
        }
        System.out.println(array);
    }
}
