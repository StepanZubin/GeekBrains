package OOP.Seminar_1;

public class Coffee extends Product {
    private String brand;
    private String type;
    private int weight;
    
    public Coffee(String name) {
        super(name);
    }
    
    public Coffee(String name, double price) {
        super(name, price);
    }

    public Coffee(String name, double price, String brand, String type, int weight) {
        super(name, price);
        this.brand = brand;
        this.type = type;
        this.weight = weight;
    }

    public String getBrand() {
        return this.brand;
    }

    public String getType() {
        return this.type;
    }

    public int getWeight() {
        return this.weight;
    }

    @Override
    public String toString() {
        return String.format("%s %s %s %d %s", super.toString(), brand, type, weight, "гр./");
    }
}
