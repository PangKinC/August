package computerShop;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by student on 26-Aug-16.
 */
public class Generator {

    public static List<Computer> computers = new ArrayList<>();
    public static List<Desktop> desktops = new ArrayList<>();
    public static List<Laptop> laptops = new ArrayList<>();
    public static List<Customer> customers = new ArrayList<>();

    public static Desktop comp1 = new Desktop("Alienware", "Intel i7-5820K", 3.3, "GeForce GTX980", 32,
            4000, 2898.99, "No Monitor", "No Keyboard", "No Mouse");

    public static Desktop comp2 = new Desktop("ASUS", "Intel i7-6700", 3.4, "GeForce GTX970", 16,
            2128, 1299.97, "No Monitor", "USB Keyboard", "USB Mouse", "Logitech Z333");

    public static Desktop comp3 = new Desktop("HP-Envy", "Intel i7-6700T", 2.8, "GeForce GTX 960A", 8,
            1128, 1999.99, "SAMSUNG S24E510C", "Wireless Optical Keyboard", "Wireless Optical Mouse");

    public static Laptop lap1 = new Laptop("ASUS", "Intel i7-6700HQ", 2.6, "GeForce GTX970M", 16,
            1256, 1499.99, 8, 3.95);

    public static Laptop lap2 = new Laptop("MacBook Pro", "Intel i7", 2.5, "AMD Radeon R9 M370X", 16,
            512, 1999.99, 9, 2.04);

    public static Customer cus1 = new Customer("Kin", "Pang", LocalDate.of(1990, 01, 22),
            "29 Walpole Road, Walthamstow, London, E17 6PS", "Same as address", "07858374977",
            "4658580811429206", "kinchungpang@gmail.com");

    public static Customer cus2 = new Customer("Test", "Test", LocalDate.of(2001, 01, 01),
            "Test", "Test", "12345678901", "1111222233334444", "test@test.com");

    public static Customer cus3 = new Customer("sdasda", "sdadsada", LocalDate.of(2012, 12, 12),
            "sdadada", "sdadsadsa", "dsfasadsada", "sdadadsa", "sdsadsadsa");

    static void addComputers() {


        computers.add(comp1);
        computers.add(comp2);
        computers.add(comp3);
        computers.add(lap1);
        computers.add(lap2);


        desktops.add(comp1);
        desktops.add(comp2);
        desktops.add(comp3);
        laptops.add(lap1);
        laptops.add(lap2);
        customers.add(cus1);
        customers.add(cus2);
        customers.add(cus3);

        cus1.addComp(comp1);
        cus1.addComp(lap1);

        cus2.addComp(comp2);
        cus2.addComp(comp1);

        cus3.addComp(comp3);
        cus3.addComp(lap2);
    }

}
