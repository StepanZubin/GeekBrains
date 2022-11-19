package OOP.Seminar_1;

public class Product {
    private String name;
    private double price;

    public Product(String name, double price) {
        this(name);
        this.price = price;
    }

    public Product(String name) {
        this.name = name;
    }

    public String getName() {
        return this.name; // можно без "this" - просто "name"
    }

    public double getPrice() {
        return this.price;
    }

    public void setPrice(double value) {
        if (value <= 0) return;
        this.price = value;
    }

    @Override
    public String toString() {
        return String.format("%s %.2f", this.name, this.price);
    }
}
