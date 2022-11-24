public class Fish extends Animal implements Swimable {

    public Fish(String name, String breed, String colour, Integer countLegs, Integer age) {
        super(name, breed, colour, countLegs, age);
    }  

    public String swim() {
        return "45 km/h";
    }
}
