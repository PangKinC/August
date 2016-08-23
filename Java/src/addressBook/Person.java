package addressBook;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

/**
 * Created by student on 23-Aug-16.
 */
public class Person {
    private String firstName;
    private String lastName;
    private LocalDate birthDate;

    public String getFirstName() {
        return firstName;
    }

    public void setFirstName(String firstName) {
        this.firstName = firstName;
    }

    public String getLastName() {
        return lastName;
    }

    public void setLastName(String lastName) {
        this.lastName = lastName;
    }

    public LocalDate getBirthDate() {
        return birthDate;
    }

    public void setBirthDate(LocalDate birthDate) { this.birthDate = birthDate; }

    Person() {}

    public Person(String firstName, String lastName, LocalDate birthDate) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }

    public long getAge() {
        if (birthDate == null){
            return 0 ;
        }
        long years = ChronoUnit.YEARS.between(birthDate, LocalDate.now());
        return years;
    }

    @Override
    public String toString() {
        return String.format("%s %s, %s.", this.firstName, this.lastName, this.birthDate, this.getAge());
    }

}
