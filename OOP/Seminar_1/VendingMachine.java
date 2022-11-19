package OOP.Seminar_1;

import java.util.ArrayList;
import java.util.List;

public class VendingMachine {
    private List<Product> products; // = new ArrayList<>();

    private final static List<Product> initProduct = new ArrayList<>();  // final - "неизменяемый" список (не можем создать новый список)/защищает только ссылку

    static {
        initProduct.add(new Product("Сникерс", 60.0));
    }

    public VendingMachine() {
        this(initProduct);
    }

    public VendingMachine(List<Product> prods) {
        this.products = prods;
    }

    public VendingMachine(String name, double price) {
        this.products = new ArrayList<>();
        products.add(new Product(name, price));
    }

    public Product getProductBy(String inpName) {  // вместо: getProductByName -> getProductBy
        for (Product product : products) {
            if (product.getName().contains(inpName)) {
                return product;
            }
        }
        return null;  // "null" - лучше не возвращать ! (лучше вернуть какой-то объект)
    }

    public Product getProductBy(double inpPrice) { // вместо: getProductByPrice -> getProductBy
        for (Product product : products) {
            if (product.getPrice() == inpPrice) {
                return product;
            }
        }
        return null; 
    }

    @Override
    public String toString() {
        String result = "";
        for (Product product : products) {
            result = result.concat(product.toString() + "\n"); // мозно добавить делиметр: ... + ";")
        }
        return result;
    }
}
