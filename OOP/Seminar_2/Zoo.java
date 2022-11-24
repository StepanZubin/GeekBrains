import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class Zoo {
    private List<Animal> animals;
    public Zoo() {
        animals = new ArrayList<>(Arrays.asList(
            new Crocodile("Dundee", "tricky", "green", 4, 52),
            new Duck("Donald", "utkonos", "yellow", 2, 10), 
            new Fish("Saw", "dangerous", "brown", 0, 41), 
            new Cat("Barsik", "vislouh", "black", 4, 6), 
            new Dog("Sedi", "rotveller", "brown", 4, 2)));

    }

    public void talk() { //talk - говорить
        for (Speakable item : getSpeakables()) {
            System.out.printf("%s\n", item.speak());
        }
    }
    public List<Speakable> getSpeakables() {
        List<Speakable> result = new ArrayList<>();
        for (Animal speakItem : animals) {
            if (speakItem instanceof Speakable) {
                result.add((Speakable) speakItem);
            }
        }
        result.add(new Radio());
        return result;
    }
    
    public List<Runable> getRunables() {
        List<Runable> result = new ArrayList<>();
        for (Animal runItem : animals) {
            if (runItem instanceof Runable) {
                result.add((Runable) runItem);
            }
        }
        return result;
    }

    public List<Flyable> getFlyables() {
        List<Flyable> result = new ArrayList<>();
        for (Animal flyItem : animals) {
            if (flyItem instanceof Flyable) {
                result.add((Flyable) flyItem);
            }
        }
        return result;
    }    

    public List<Swimable> getSwimables() {
        List<Swimable> result = new ArrayList<>();
        for (Animal swimItem : animals) {
            if (swimItem instanceof Swimable) {
                result.add((Swimable) swimItem);
            }
        }
        return result;
    }  

    public void runMoving() {
        for (Runable item : getRunables()) {
            System.out.printf("%s, %s\n",item.toString(), item.run());
        }
    }

    public void flyMoving() {
        for (Flyable item : getFlyables()) {
            System.out.printf("%s, %s\n",item.toString(), item.fly());
        }
    }

    public void swimMoving() {
        for (Swimable item : getSwimables()) {
            System.out.printf("%s, %s\n",item.toString(), item.swim());
        }
    }
}
