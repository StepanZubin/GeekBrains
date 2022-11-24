import java.util.Random;

public class Teams {
    public static void main(String[] args) {
        int teamCount = 10; // кол-во персонажей
        Random rand = new Random();
        int magicianCount = rand.nextInt(teamCount); // кол-во магов
        int priestCount = teamCount - magicianCount; // кол-во жрецов

        System.out.printf("magicalCount: %d priestCount: %d \n", magicianCount, priestCount);

        Priest[] priests = new Priest[priestCount]; // массив для хронения жрецов
        Magician[] magicians = new Magician[magicianCount]; // массив для хранения магов

        for (int i = 0; i < priestCount; i++) {
            priests[i] = new Priest();
            System.out.println(priests[i].getInfo());
        }
        System.out.println();

        for (int i = 0; i < magicianCount; i++) {
            magicians[i] = new Magician();
            System.out.println(magicians[i].getInfo());
        }
    }
}
