public class Crocodile extends Animal implements Speakable, Runable, Swimable {

    public Crocodile(String name, String breed, String colour, Integer countLegs, Integer age) {
        super(name, breed, colour, countLegs, age);
    }

    @Override
    public String run() {
        return "15 km/h";
    }

    @Override
    public String speak() {
        return "roar"; //roar - рокот
    }
    
    @Override
    public String swim() {
        return "45 km/h";
    }
}
