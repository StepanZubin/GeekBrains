package OOP.Lecture_2.Ex000;

public class Foo {
    public Integer value;

    private static Integer count;
    public static int getCount() {
        return count; //при обращении к статическим членам -> "this" и "super" не используем
    }

    static {
        count = 0;
    }

    public Foo() {
        count++;
    }

    public void printCount() {
        System.out.println(count);
    }

    @Override
    public String toString() {
        return super.toString();
    }
}
