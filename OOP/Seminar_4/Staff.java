package OOP.Seminar_4;

public class Staff implements Weapon {  //посох

    @Override
    public Integer damage() {
        return 10;
    }

    @Override
    public String toString() {
        return String.format("Staff - %d", damage());
    }
    
}
