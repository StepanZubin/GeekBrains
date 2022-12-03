package OOP.Lecture_1.proba2;

import OOP.Lecture_1.Ex002.Point2D;

public class program {
    static double dist(Point2D a, Point2D b) {
        return Math.sqrt(Math.pow(a.x - b.x, 2) + Math.pow(a.y - b.y, 2));
    }

    public static void main(String[] args) {
        Point2D a = new Point2D();
        a.x = 3;
        a.y = 2;

        Point2D b = new Point2D();
        b.x = 5;
        b.y = 6;

    }
}
