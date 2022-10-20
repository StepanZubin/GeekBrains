// Даны следующие строки, cравнить их с помощью == и метода equals() 
// класса Object
// String s1 = "hello";
// String s2 = "hello";
// String s3 = s1;
// String s4 = "h" + "e" + "l" + "l" + "o";
// String s5 = new String("hello");
// String s6 = new String(new char[]{'h', 'e', 'l', 'l', 'o'});

public class task_1 {

    public static void stringСomparison(String str1, String str2) {
        System.out.println(str1 == str2);  // сравнение ссылок на объект
    }

    public static void stringСomparisonEquals(String str1, String str2) {
        System.out.println(str1.equals(str2));  // сравнение содержимого (значений) !
    }


    public static void main(String[] args) {

        String s1 = "hello";
        String s2 = "hello";
        String s3 = s1;
        String s4 = "h" + "e" + "l" + "l" + "o";
        String s5 = new String("hello");
        String s6 = new String(new char[]{'h', 'e', 'l', 'l', 'o'});

        stringСomparison(s1, s2);
        stringСomparisonEquals(s1, s2);

        stringСomparison(s3, s4);
        stringСomparisonEquals(s3, s4);

        stringСomparison(s5, s6);
        stringСomparisonEquals(s5, s6);

    }
}
