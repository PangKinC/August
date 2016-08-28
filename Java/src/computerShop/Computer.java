package computerShop;

/**
 * Created by student on 26-Aug-16.
 */

public abstract class Computer implements Comparable<Computer> {

    private String model;
    private String cpuModel;
    private String gpuModel;
    private double cpuSpeed;
    private int ram;
    private int hdSpace;
    private double price;
    private int compStock = 0;

    Computer () {}

    public Computer(String model, String cpuModel, double cpuSpeed, String gpuModel, int ram, int hdSpace, double price) {
        this.model = model;
        this.cpuModel = cpuModel;
        this.cpuSpeed = cpuSpeed;
        this.gpuModel = gpuModel;
        this.ram = ram;
        this.hdSpace = hdSpace;
        this.price = price;
        compStock++;
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

    public int getRam() {
        return ram;
    }

    public void setRam(int ram) {
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
        return String.format("Model: %s, CPU: %s, CPU Speed: %sGHz, GPU: %s, RAM: %sGB, \nHD Space: %sGB, Price: £%s", this.model, this.cpuModel, this.cpuSpeed, this.gpuModel, this.ram, this.hdSpace, this.price);
    }


    public int compareTo(Computer c) {

        return new Double(c.getPrice()).compareTo(price);
    }

}
