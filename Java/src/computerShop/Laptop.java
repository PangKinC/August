package computerShop;

/**
 * Created by student on 26-Aug-16.
 */
public class Laptop extends Computer {

    private short batteryLife;
    private double weight;

    public short getBatteryLife() {
        return batteryLife;
    }

    public void setBatteryLife(short batteryLife) {
        this.batteryLife = batteryLife;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    Laptop() {}

    public Laptop(String model, String cpuModel, double cpuSpeed, String gpuModel, short ram, int hdSpace, double price, short batteryLife, double weight) {
        super(model, cpuModel, cpuSpeed, gpuModel, ram, hdSpace, price);
        this.batteryLife = batteryLife;
        this.weight = weight;
    }

    @Override
    public String toString() {
        return String.format("Laptop: %s, %s, %s.", super.toString(), this.batteryLife, this.weight);
    }

}
