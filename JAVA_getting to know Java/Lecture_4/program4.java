import java.util.LinkedList;
import java.util.PriorityQueue;
import java.util.Queue;
import java.util.Stack;
import java.util.ArrayDeque;
import java.util.Deque;


// //  LinkedList
// public class program4 {
//     public static void main(String[] args) {
//         LinkedList<Integer> ll = new LinkedList<Integer>();

//         ll.addLast(1);
//         ll.addLast(2);
//         ll.addLast(3);

//         System.out.println(ll);  // [1, 2, 3]
//     }
// }



// // Queue
// public class program4 {
//     public static void main(String[] args) {
//     Queue<Integer> queue = new LinkedList<Integer>();

//         queue.add(1);
//         queue.add(2);
//         queue.add(3);
//         queue.add(4);
//         System.out.println(queue);  // [1, 2, 3, 4]

//         int item = queue.remove();
//         System.out.println(queue);  // [2, 3, 4]

//         queue.offer(2809);
//         item = queue.remove();
//         System.out.println(queue);  // [3, 4, 2809]

//         item = queue.remove();
//         System.out.println(queue);  // [4, 2809]

//         item = queue.poll();
//         System.out.println(queue);  // [2809]
//     }
// }



// // PriorityQueue
// public class program4 {
//     public static void main(String[] args) {
//         PriorityQueue<Integer> pq = new PriorityQueue<Integer>();
//         pq.add(123);
//         pq.add(3);
//         pq.add(13);
//         pq.add(1);
//         System.out.println(pq);  // [1, 3, 13, 123]
//         System.out.println(pq.poll());  // 1
//         System.out.println(pq.poll());  // 3
//         System.out.println(pq.poll());  // 13
//         System.out.println(pq.poll());  // 123
//         System.out.println(pq.poll());  // null
//     }
// }



// // Deque
// public class program4 {
//     public static void main(String[] args) {
//         Deque<Integer> deque = new ArrayDeque<>();
//         Deque<Integer> deque = new ArrayDeque<>();
//         deque.addFirst(1);    deque.addLast(2);
//         deque.removeLast();     deque.removeLast();
//         deque.offerFirst(1); deque.offerLast(2);
//         deque.pollFirst();      deque.pollLast();
//         deque.getFirst();       deque.getLast();
//         deque.peekFirst();      deque.peekLast();
//     }
// }



// // Stack
// public class program4 {
//     public static void main(String[] args) {

//         //var exp = "1 2 + 3 *".split(" ");  // (1 + 2) * 3

//         var exp = "1 2 3 * +".split(" ");  // 1 + 2 + 3
//         int res = 0;
//         System.out.println(exp);

//         Stack<Integer> st = new Stack<>();
//         for (int i = 0; i < exp.length; i++) {
            
//             if (isDigit(exp[i])) {
//                 st.push(Integer.parseInt(exp[i]));
//             } else {
//                 switch (exp[i]) {
//                     case "+":
//                         res = st.pop() + st.pop();
//                         st.push(res);
//                         break;
//                     case "-":
//                         res = -st.pop() + st.pop();
//                         st.push(res);
//                         break;
//                     case "*":
//                         res = st.pop() * st.pop();
//                         st.push(res);
//                         break;
//                     case "/":
//                         res = st.pop() / st.pop();
//                         st.push(res);
//                         break;
//                     default:
//                         break;
//                 }
//             }
//         }
//         System.out.printf("%d\n", st.pop());
//     }
// }

