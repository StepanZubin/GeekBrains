package OOP.Seminar_4;

public class Archer extends Warrior<Bow, Shild> { //Лучник

    private Integer range; //дальность
    private Integer protect; //защита

    public Archer(String name, Bow weapon, Shild protection, Integer healthPoint, Integer range, Integer protect) {
        super(name, weapon, protection, healthPoint);
        this.range = range;
        this.protect = protect;
    }

    public Integer getRange() {
        return range;
    }
    
    @Override
    public String toString() {
        return String.format("Archer - %s, range - %d, protection - %d", super.toString(), range, protect);
    }
}
