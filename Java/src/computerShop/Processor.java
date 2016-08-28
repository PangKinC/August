package computerShop;

import java.time.LocalDate;
import java.util.Collections;
import java.util.Comparator;
import java.util.List;

import static computerShop.Generator.*;

/**
 * Created by student on 26-Aug-16.
 */
public class Processor {

    static void addNewDesktop(List<String> data) {
        Desktop temp = new Desktop(
                data.get(0),
                data.get(1),
                Double.parseDouble(data.get(2)),
                data.get(2),
                Integer.parseInt(data.get(4)),
                Integer.parseInt(data.get(5)),
                Double.parseDouble(data.get(6)),
                data.get(7),
                data.get(8),
                data.get(9),
                data.get(10));

        desktops.add(temp);

    }

    static void addNewLaptop(List<String> data) {
        Laptop temp = new Laptop(
                data.get(0),
                data.get(1),
                Double.parseDouble(data.get(2)),
                data.get(3),
                Integer.parseInt(data.get(4)),
                Integer.parseInt(data.get(5)),
                Double.parseDouble(data.get(6)),
                Short.parseShort(data.get(7)),
                Double.parseDouble(data.get(8)));

        laptops.add(temp);

    }

    static void addNewCustomer(List<String> data) {
        Customer temp = new Customer(
                data.get(0),
                data.get(1),
                LocalDate.of(
                        Integer.parseInt(data.get(2)),
                        Integer.parseInt(data.get(3)),
                        Integer.parseInt(data.get(4))),
                data.get(5),
                data.get(6),
                data.get(7),
                data.get(8),
                data.get(9));

        customers.add(temp);

    }

    static void buyDesktop(double num) {

        for (Desktop d : desktops) {
            if (num == d.getCpuSpeed()){
                for (Customer c : customers) {
                    if (c.getCusDesktop().contains(d)) { System.out.println("Already have this desktop."); }
                    else {
                        System.out.println(String.format("Buying: %s ", d));
                        c.addDesktop(d);
                    }
                }
            }
        }
    }

    static void buyLaptop(double num) {

        for (Laptop l : laptops) {
            if (num == l.getCpuSpeed()){
                for (Customer c : customers) {
                    if (c.getCusLaptops().contains(l)) { System.out.println("Already have this laptop."); }
                    else {
                            System.out.println(String.format("Buying: %s ", l));
                            c.addLaptop(l);
                    }
                }
            }
        }
    }



    static void listComputers() {

        /*for (Desktop d : desktops) {
            System.out.println(String.format("\n[%s] " + d, desktops.indexOf(d)));
        }

        for (Laptop l : laptops) {
            System.out.println(String.format("\n[%s] " + l, laptops.indexOf(l)));
        }*/


        Collections.sort(computers);

        for (Computer c : computers) {
            System.out.println(String.format("\n[%s] " + c, computers.indexOf(c)));
        }

        /*for (Customer c : customers) {
            System.out.println(String.format("\n[%s] " + c, customers.indexOf(c)));
            System.out.println(String.format("%s", c.getCusDesktop()));
            System.out.println(String.format("%s", c.getCusLaptops()));
        }*/

    }

    static void listCustomers() {
        /*Collections.sort(customers, new Comparator<Customer>() {
            @Override
            public int compare(Customer o1, Customer o2) {
            }
        })*/
    }

    static int searchComputer(double speed){
        for (Computer c : computers) {
            if (c.getCpuSpeed() == speed) {
                return desktops.indexOf(c);
            }

        }
        return -1;
    }

}
