package dayTwo.OOP;

import java.time.LocalDate;
import java.util.List;

import static dayTwo.OOP.peopleGenerator.people;

/**
 * Created by student on 23-Aug-16.
 */

public class taskProcessing {
    static void createEmployee(List<String> data){

        Employee temp = new Employee(
                data.get(0),
                data.get(1),
                Short.parseShort(data.get(2)),
                Double.parseDouble(data.get(3)),
                LocalDate.of(Integer.parseInt(data.get(4)), Integer.parseInt(data.get(5)),
                        Integer.parseInt(data.get(6))),
                checkSex(data.get(7)),
                data.get(8),
                LocalDate.of(Integer.parseInt(data.get(9)), Integer.parseInt(data.get(10)),
                        Integer.parseInt(data.get(11)))
        );

        people.add(temp);

    }

    static void printAll() {
        for (Person e : people) {
            System.out.println(String.format("%s " + e, people.indexOf(e)));
        }
    }

    static int searchPerson(String firstName){
        for (Person p : people) {
            if (p.getFirstName().contains(firstName)){
                return people.indexOf(p);
            }
        }
        return - 1;
    }

    static void editDetails(int index, List<String> data) {
        people.get(index).setFirstName(data.get(0));
        people.get(index).setLastName(data.get(1));
        people.get(index).setHeight(Short.parseShort(data.get(2)));
        people.get(index).setWeight(Double.parseDouble(data.get(3)));
        people.get(index).setBirthDate(LocalDate.of(
                Integer.parseInt(data.get(4)),
                Integer.parseInt(data.get(5)),
                Integer.parseInt(data.get(6))));
        people.get(index).setSex(checkSex(data.get(7)));
        people.get(index).setPosition(data.get(8));
        people.get(index).setHireDate(LocalDate.of(
                Integer.parseInt(data.get(9)),
                Integer.parseInt(data.get(10)),
                Integer.parseInt(data.get(11))));

    }

    static SexType checkSex(String data){
        if (data.contains("M")){
            return SexType.MALE;
        }
        else {
            return SexType.FEMALE;
        }
    }

    static void removeEmployee(int index) {
        people.remove(index);
    }

}
