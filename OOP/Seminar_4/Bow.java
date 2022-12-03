package OOP.Seminar_4;

public class Bow implements Weapon { //лук

    @Override
    public Integer damage() {
        return 30;
    } 
    
    @Override
    public String toString() {
        return String.format("Bow - %d", damage());
    }
}
