package dayTwo.OOP;

import java.time.LocalDate;
import java.time.temporal.ChronoUnit;

/**
 * Created by student on 23-Aug-16.
 */
public abstract class Person {
    //fields
    private String firstName;
    private String lastName;
    private short height;
    private double weight;
    private LocalDate birthDate;

    private SexType sex;
    private BloodType bloodType;

    private boolean isSleeping = false;

    //properties

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

    public short getHeight() {
        return height;
    }

    public void setHeight(short height) {
        this.height = height;
    }

    public double getWeight() {
        return weight;
    }

    public void setWeight(double weight) {
        this.weight = weight;
    }

    public LocalDate getBirthDate() {
        return birthDate;
    }

    public void setBirthDate(LocalDate birthDate) {
        this.birthDate = birthDate;
    }

    public SexType getSex() {
        return sex;
    }

    public void setSex(SexType sex) {
        this.sex = sex;
    }

    public BloodType getBloodType() {
        return bloodType;
    }

    public void setBloodType(BloodType bloodType) {
        this.bloodType = bloodType;
    }

    //constructors

    Person() {}

    public Person(String firstName, String lastName, LocalDate birthDate) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.birthDate = birthDate;
    }

    public Person(String firstName, String lastName, short height, double weight, LocalDate birthDate, SexType sex) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.height = height;
        this.weight = weight;
        this.birthDate = birthDate;
        this.sex = sex;
        //this.bloodType = bloodType;
    }

    //methods

    public long getAge() {
        if (birthDate == null){
            return 0 ;
        }
        long years = ChronoUnit.YEARS.between(birthDate, LocalDate.now());
        return years;
    }

    public String talk() throws Exception {
        if (isSleeping) { throw new Exception("Cannot talk while sleeping ... "); }
        return String.format("%s %s says hello! I'm awake!", this.firstName, this.lastName);
    }

    public void sleep() {
        isSleeping = true;
    }

    @Override
    public String toString() {
        return String.format(" Person: %s %s %s %s %s %s ", this.firstName, this.lastName, this.getAge(), this.height,
                                this.weight, this.getSex().toString());
    }
}
