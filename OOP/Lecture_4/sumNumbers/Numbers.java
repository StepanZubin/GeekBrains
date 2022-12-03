package OOP.Lecture_4.sumNumbers;

public class Numbers {
    int n;
    public Numbers(int value) {
        n = value;
    }
    @Override
    public String toString() {
        return String.format("n: %d", n);
    }
}
