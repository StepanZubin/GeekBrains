package OOP.Lecture_1.proba;



public class program {

    static double dist(int x1, int x2, int y1, int y2) {
        return Math.sqrt(Math.pow(x2 - x1, 2) + Math.pow(y2 - y1, 2));
    }
    public static void main(String[] args) {
        
        int ax = 2;
        int ay = 3;

        int bx = 1;
        int by = -7;

        System.out.printf("%d %d %d %d\n", ax, ay, bx, by);
        System.out.println(dist(ax, ay, bx, by));
    }
    
}
