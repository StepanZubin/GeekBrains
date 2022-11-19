package OOP.Lecture_1.Ex002;

public class Program {
    // Так было раньше:
    static double distance(int x1, int y1, int x2, int y2) {
        return Math.sqrt(Math.pow( x2 - x1, 2) + Math.pow(y2 - y1, 2));
    }

    // Теперь новый метод, принимающий 2-е точки (следующий уровень абстракции)
    static double distance(Point2D a, Point2D b) {
        return Math.sqrt(Math.pow( a.x - b.x, 2) + Math.pow(a.y - b.y, 2));
    }

   // Kлиентский код
    public static void main(String[] args) {
        Point2D a = new Point2D(0, 2); // определяем экземпляр класса "точка"
        // a.x = 0; // указываются конкретные значения нужных полей
        // a.y = 2;
        System.out.println(a);

        Point2D b = new Point2D(10); // значение 10, как для x, так для y
        // b.x = 10;
        // b.y = 10;
        // System.out.println(b.toString());
        System.out.println(distance(a, b)); // вычисляем значение, исп-я м-д: distance()
    }
}
