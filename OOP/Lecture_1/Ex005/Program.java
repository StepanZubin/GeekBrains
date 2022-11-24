package OOP.Lecture_1.Ex005;

public class Program {
    public static void main(String[] args) {
        //создаём мага
        Magician hero1 = new Magician();
        System.out.println((hero1.getInfo()));

        //создаём жреца
        Priest hero2 = new Priest();
        System.out.println(hero2.getInfo());

        //создаём ещё жреца
        Priest hero3 = new Priest();
        System.out.println(hero3.getInfo());
    }
}
