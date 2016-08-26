package computerShop;

/**
 * Created by student on 26-Aug-16.
 */
public class Desktop extends Computer {

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

    Desktop(){}

    public Desktop(String model, String cpuModel, double cpuSpeed, String gpuModel, short ram, int hdSpace, double price, String keyboard, String monitor, String mouse) {
        super(model, cpuModel, cpuSpeed, gpuModel, ram, hdSpace, price);
        this.keyboard = keyboard;
        this.monitor = monitor;
        this.mouse = mouse;
        hasSpeakers = false;
    }

    public Desktop(String model, String cpuModel, double cpuSpeed, String gpuModel, short ram, int hdSpace, double price, String keyboard, String monitor, String mouse, String speakers) {
        super(model, cpuModel, cpuSpeed, gpuModel, ram, hdSpace, price);
        this.hasSpeakers = true;
        this.keyboard = keyboard;
        this.monitor = monitor;
        this.mouse = mouse;
        this.speakers = speakers;
        hasSpeakers = true;
    }

    @Override
    public String toString() {

        if (hasSpeakers == false) {
            stringSentence = String.format("Desktop: %s, %s, %s, %s.", super.toString(), this.keyboard, this.monitor, this.mouse);
        }
        else {
            stringSentence = String.format("Desktop: %s, %s, %s, %s, %s.", super.toString(), this.keyboard, this.monitor, this.mouse, this.speakers);
        }
        return stringSentence;

    }

}
