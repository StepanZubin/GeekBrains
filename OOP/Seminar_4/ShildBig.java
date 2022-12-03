package OOP.Seminar_4;

public class ShildBig extends ShildRound{  //большой щит

    @Override
    public Integer absorb() {
        return 20;
    }
    
    @Override
    public String toString() {
        return String.format("ShildBig - %d", absorb());
    }
}
