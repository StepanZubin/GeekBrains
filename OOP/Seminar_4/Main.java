package OOP.Seminar_4;

public class Main {
    public static void main(String[] args) {
        Hero hero1 = new Hero("Hiro", new Staff(), new Shild(), 150);
        Hero hero2 = new Hero("Imir", new Staff(), new ShildRound(), 150);

        Team<Archer> red = new Team<>(hero1); //список команды "red" (лучники)
        red.add(new Archer("Man", new LongBow(), new Shild(), 100, 20, 10));
        red.add(new Archer("Alex", new Bow(), new Shild(), 100, 15, 10));

        System.out.println(red);
        System.out.printf(" * red: overall team health - %d\n\n", (red.getTeamHelsPoint()));
   

        Team<Warrior> blue = new Team<>(hero2); //смешанная команда (лучники и маги)
        blue.add(new Archer("Man2", new Bow(), new Shild(), 100, 20, 10));
        blue.add(new Mage("Alex2", new Staff(), new ShildBig(), 100, 15, 30, 20));

       System.out.println(blue);

       System.out.printf(" * blue: overall team health - %d\n", (blue.getTeamHelsPoint())); //общее здоровье команды "blue"

    }
}
