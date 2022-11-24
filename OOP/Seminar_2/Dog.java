//Dog наследник Animal
public class Dog extends Animal implements Speakable, Runable {
    //implements - Spekable ссылается на Animal

    public Dog(String name, String breed, String colour, Integer countLegs, Integer age) {
        super(name, breed, colour, countLegs, age);
    }

    @Override
    public String speak() {
        return "woof"; //woof - гав
    }

    @Override
    public String run() {
        return "60 km/h";
    }
    
}
