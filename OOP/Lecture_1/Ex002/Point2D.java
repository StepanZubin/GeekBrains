package OOP.Lecture_1.Ex002;

public class Point2D {
    int x, y; // раньше назавались переменные, теперь - поля

    // создаём конструктор (не метод, т.к. нет возвращаемого типа !)
    public Point2D(int valueX, int valueY) {  // "ctor" 
        x = valueX;
        y = valueY;
    }

    public Point2D() {
        x = 0;
        y = 0; 
    }

    public Point2D(int value) {
        x = value;
        y = value;
    }
}

