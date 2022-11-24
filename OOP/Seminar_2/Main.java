public class Main {
    public static void main(String[] args) {
        Zoo zoo = new Zoo();
        zoo.talk();
        System.out.println("-> run: ");
        zoo.runMoving();
        System.out.println("-> fly: ");
        zoo.flyMoving();
        System.out.println("-> swim: ");
        zoo.swimMoving();
    }
}
