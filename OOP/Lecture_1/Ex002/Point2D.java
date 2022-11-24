package OOP.Lecture_1.Ex002;

/**
 * Это точка 2D
 */
public class Point2D {
    private int x, y; // раньше назавались переменные, теперь - поля

    // 
    /**
     * это конструктор (не метод, т.к. нет возвращаемого типа !)
     * @param valueX это координата X
     * @param valueY это координата Y
     */
    public Point2D(int valueX, int valueY) {  // "ctor" 
        x = valueX;
        y = valueY;
    }

    public Point2D(int value) {
        this(value, value); // вызов конструктора с двумя аргументами
    }

    public Point2D() {
        this(0); // вызов конструктора с одним аргументом
    }

    // public Point2D() {
    //     x = 0;
    //     y = 0; 
    // }

    // public Point2D(int value) {
    //     x = value;
    //     y = value;
    // }

    public int getX() {
        return x;
    }

    public int getY() {
        return y;
    }

    public void setX(int value) {
        this.x = value;
    }

    public void setY(int value) {
        this.y = value;
    }

    public String getInfo() { // технически этот м-д не нужен (м-но подставить в метод ниже)
        return String.format("x: %d; y: %d", x, y);
    }

    @Override  // переопределение toString() - к-й есть по умолчанию
    public String toString() {
        return getInfo();
    }

    static double distance(Point2D a, Point2D b) {
        return Math.sqrt(Math.pow( a.getX() - b.getX(), 2) + Math.pow(a.getY() - b.getY(), 2));
    }

}

