package computerShop;

/**
 * Created by student on 26-Aug-16.
 */
public class Desktop extends Computer {

    private int deskStock;
    private int totalPrice;
    private int totalStock;
    private String mouse;
    private String keyboard;
    private String monitor;
    private String speakers;
    private boolean hasSpeakers;
    private String stringSentence;

    public String getKeyboard() {
        return keyboard;
    }

    public void setKeyboard(String keyboard) {
        this.keyboard = keyboard;
    }

    public String getMonitor() {
        return monitor;
    }

    public void setMonitor(String monitor) {
        this.monitor = monitor;
    }

    public String getMouse() {
        return mouse;
    }

    public void setMouse(String mouse) {
        this.mouse = mouse;
    }

    public String getSpeakers() {
        return speakers;
    }

    public void setSpeakers(String speakers) {
        this.speakers = speakers;
    }

    public int getDeskStock() {
        return deskStock;
    }

    public int getTotalPrice() { return totalPrice; }

    public int getTotalStock() {
        return totalStock;
    }

    Desktop(){}

    public Desktop(String model, String cpuModel, double cpuSpeed, String gpuModel, int ram, int hdSpace, double price, String monitor, String keyboard, String mouse) {
        super(model, cpuModel, cpuSpeed, gpuModel, ram, hdSpace, price);
        this.keyboard = keyboard;
        this.monitor = monitor;
        this.mouse = mouse;
        hasSpeakers = false;
        deskStock++;
        totalPrice += price;
        totalStock += deskStock;
    }

    public Desktop(String model, String cpuModel, double cpuSpeed, String gpuModel, int ram, int hdSpace, double price, String monitor, String keyboard, String mouse, String speakers) {
        super(model, cpuModel, cpuSpeed, gpuModel, ram, hdSpace, price);
        this.hasSpeakers = true;
        this.keyboard = keyboard;
        this.monitor = monitor;
        this.mouse = mouse;
        this.speakers = speakers;
        hasSpeakers = true;
        deskStock++;
        totalPrice += price;
        totalStock += deskStock;
    }

    @Override
    public String toString() {

        if (hasSpeakers == false) {
            stringSentence = String.format("Desktop: %s, Monitor: %s, Keyboard: %s, Mouse: %s.", super.toString(), this.monitor, this.keyboard, this.mouse);
        }
        else {
            stringSentence = String.format("Desktop: %s, Monitor: %s, Keyboard: %s, Mouse: %s, Speakers: %s.", super.toString(), this.monitor, this.keyboard, this.mouse, this.speakers);
        }
        return stringSentence;

    }

}
