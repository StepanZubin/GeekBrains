package OOP.Seminar_4;

public class Hero extends Warrior { //командир

    public Hero(String name, Weapon weapon, Protection protection, Integer healthPoint) {
        super(name, weapon, protection, healthPoint);
    }

    @Override
    public String toString() {
        return String.format("Hero - %s", super.toString());
    }
    
}
