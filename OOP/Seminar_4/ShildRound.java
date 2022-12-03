package OOP.Seminar_4;

public class ShildRound  extends Shild { //круглый щит

    @Override
    public Integer absorb() {
        return 15;
    } 
    
    @Override
    public String toString() {
        return String.format("ShildRound - %d", absorb());
    }
}
