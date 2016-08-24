package dayTwo.OOP;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by student on 23-Aug-16.
 */
public class peopleGenerator {
    //public static Person person1 = new Person("Kin", "Pang", (short)178, 60.0, LocalDate.of(1990, 1, 22), SexType.MALE, BloodType.O);

    public static Employee emp1 = new Employee("Kin", "Pang", (short)178, 60.0, LocalDate.of(1990, 1, 22), SexType.MALE, "Student", LocalDate.of(2016, 8, 23));

    public static List<Employee> people = new ArrayList<>();

    static void addPeople() {
        //people.add(person1);
        people.add(emp1);
    }

}
