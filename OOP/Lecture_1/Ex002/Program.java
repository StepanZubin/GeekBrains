package OOP.Lecture_1.Ex002;

public class Program {

   // Kлиентский код
    public static void main(String[] args) {
        Point2D a = new Point2D(0, 2); // определяем экземпляр класса "точка"
        a.setX(12); // есть доступ к записи ч/з setX()
        // a.x = 0; // указываются конкретные значения нужных полей
        // a.y = 2;
        System.out.println(a.getX());
        System.out.println(a.getY());

        Point2D b = new Point2D(10); // значение 10, как для x, так для y
        System.out.println(b);
        // b.x = 10;
        // b.y = 10;
        // System.out.println(b.toString());
        // System.out.println(distance(a, b)); // вычисляем значение, исп-я м-д: distance()
        var dis = Point2D.distance(a, b);
        System.out.println(dis);
    }
}
