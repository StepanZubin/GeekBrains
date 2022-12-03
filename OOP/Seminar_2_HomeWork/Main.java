package OOP.Seminar_2_HomeWork;

public class Main {
    public static void main(String[] args) {
        
        String str1 = new String("Monkey");
        String str2 = new String("Elephant");
        String str3 = new String("Parrot"); 
        String str4 = new String("Boa"); 
        // String str5 = new String();

        CartoonList<String> characters = new CartoonList<String>();
        characters.add(str1);
        characters.add(str2);
        characters.add(str3);
        characters.add(str4);

        for (String string : characters) {
            System.out.println(string);
        }
        
    }
}
