import java.util.ArrayList;
import java.util.Stack;

// 1) Написать метод, который принимает массив элементов, 
// помещает их в стэк и выводит на консоль содержимое стэка. 
// 2) Написать метод, который принимает массив элементов, 
// помещает их в linkedList и затем выводит его. 


public class task_3 {
    public static Stack<String> getStak(ArrayList<String>list) {
        Stack<String>stack = new Stack<>();
        for (int i = 0; i < list.size(); i++) {
            stack.push(list.get(i));
        }
        System.out.println(stack.pop());
        return stack;
    }

    public static void main(String[] args) {
        ArrayList<String>list = new ArrayList<>();
        Stack<String>stack = new Stack<>();
            list.add("1 зн");
            list.add("2 зн");
            list.add("3 зн");
            list.add("4 зн");
            stack = getStak(list);
            System.out.println(stack);
    }
}
