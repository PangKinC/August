package CoffeeProgramme;

/**
 * Created by student on 26-Aug-16.
 */
public class Coffee {

    private final CoffeeType type;
    private final int beans;
    private final int milk;

    public Coffee(CoffeeType type, int beans, int milk) {
        this.beans = beans;
        this.type = type;
        this.milk = milk;
    }

    public int getBeans() {
        return beans;
    }

    public int getMilk() {
        return milk;
    }

    public CoffeeType getType() {
        return type;
    }
}
