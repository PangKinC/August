package dayTwo.OOP;

import java.time.LocalDate;

/**
 * Created by student on 23-Aug-16.
 */
public class Employee extends Person {
    private String position;
    private LocalDate hireDate;

    public LocalDate getHireDate() {
        return hireDate;
    }

    public void setHireDate(LocalDate hireDate) {
        this.hireDate = hireDate;
    }

    public String getPosition() {
        return position;
    }

    public void setPosition(String position) {
        this.position = position;
    }

    Employee() {}

    Employee(String firstName, String lastName, short height, double weight, LocalDate birthDate,
                    SexType sex, String position, LocalDate hireDate) {
        super(firstName, lastName, height, weight, birthDate, sex);
        this.position = position;
        this.hireDate = hireDate;
    }

    @Override
    public String toString(){
        return String.format("Employee Name: %s %s %s", super.toString(), position, hireDate);
    }

}
