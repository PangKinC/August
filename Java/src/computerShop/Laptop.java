package computerShop;

/**
 * Created by student on 26-Aug-16.
 */
public class Laptop extends Computer {

    private int lapStock;
    private int batteryLife;
    private double weight;

    public int getBatteryLife() {
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

    public int getLapStock() {
        return lapStock;
    }

    Laptop() {}

    public Laptop(String model, String cpuModel, double cpuSpeed, String gpuModel, int ram, int hdSpace, double price, int batteryLife, double weight) {
        super(model, cpuModel, cpuSpeed, gpuModel, ram, hdSpace, price);
        this.batteryLife = batteryLife;
        this.weight = weight;
        lapStock++;
    }

    @Override
    public String toString() {
        return String.format("Laptop: %s, Battery: %s hours, Weight: %skg.", super.toString(), this.batteryLife, this.weight);
    }

}
