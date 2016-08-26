package computerShop;

import java.util.List;

import static computerShop.Generator.desktops;
import static computerShop.Generator.laptops;

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
                Short.parseShort(data.get(4)),
                Integer.parseInt(data.get(5)),
                Double.parseDouble(data.get(6)),
                data.get(7),
                data.get(8),
                data.get(9),
                data.get(10));

        desktops.add(temp);

        for (Desktop d : desktops) {
            System.out.println(String.format("\n[%s] " + d, desktops.indexOf(d)));
        }
    }

    static void addNewLaptop(List<String> data) {
        Laptop temp = new Laptop(
                data.get(0),
                data.get(1),
                Double.parseDouble(data.get(2)),
                data.get(3),
                Short.parseShort(data.get(4)),
                Integer.parseInt(data.get(5)),
                Double.parseDouble(data.get(6)),
                Short.parseShort(data.get(7)),
                Double.parseDouble(data.get(8)));

        laptops.add(temp);

        for (Laptop l : laptops) {
            System.out.println(String.format("\n[%s] " + l, laptops.indexOf(l)));
        }
    }


}
