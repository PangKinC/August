package computerShop;

/**
 * Created by student on 26-Aug-16.
 */

public abstract class Computer {

    private String model;
    private String cpuModel;
    private String gpuModel;
    private double cpuSpeed;
    private short ram;
    private int hdSpace;
    private double price;

    Computer () {}

    public Computer(String model, String cpuModel, double cpuSpeed, String gpuModel, short ram, int hdSpace, double price) {
        this.model = model;
        this.cpuModel = cpuModel;
        this.cpuSpeed = cpuSpeed;
        this.gpuModel = gpuModel;
        this.ram = ram;
        this.hdSpace = hdSpace;
        this.price = price;
    }

    public String getModel() {
        return model;
    }

    public void setModel(String model) {
        this.model = model;
    }

    public String getCpuModel() {
        return cpuModel;
    }

    public void setCpuModel(String cpuModel) {
        this.cpuModel = cpuModel;
    }

    public String getGpuModel() {
        return gpuModel;
    }

    public void setGpuModel(String gpuModel) {
        this.gpuModel = gpuModel;
    }

    public double getCpuSpeed() {
        return cpuSpeed;
    }

    public void setCpuSpeed(double cpuSpeed) {
        this.cpuSpeed = cpuSpeed;
    }

    public short getRam() {
        return ram;
    }

    public void setRam(short ram) {
        this.ram = ram;
    }

    public int getHdSpace() {
        return hdSpace;
    }

    public void setHdSpace(int hdSpace) {
        this.hdSpace = hdSpace;
    }

    public double getPrice() {
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public String toString() {
        return String.format("Computer: %s %s %s %s %s %s %s", this.model, this.cpuModel, this.cpuSpeed, this.gpuModel, this.ram, this.hdSpace, this.price);
    }
}
