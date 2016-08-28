package computerShop;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by student on 26-Aug-16.
 */
public class Customer extends Person {

    private String address;
    private String billingAddress;
    private String creditCardNo;
    private String contactNo;
    private String email;
    private List<Laptop> cusLaptops = new ArrayList<>();
    private List<Desktop> cusDesktop = new ArrayList<>();
    private List<Computer> cusComputers = new ArrayList<>();

    public List<Computer> getCusComputers() {
        return cusComputers;
    }


    public List<Laptop> getCusLaptops() {
        return cusLaptops;
    }

    public List<Desktop> getCusDesktop() {
        return cusDesktop;
    }

    public String getAddress() {
        return address;
    }

    public void setAddress(String address) {
        this.address = address;
    }

    public String getBillingAddress() {
        return billingAddress;
    }

    public void setBillingAddress(String billingAddress) {
        this.billingAddress = billingAddress;
    }

    public String getCreditCardNo() {
        return creditCardNo;
    }

    public void setCreditCardNo(String creditCardNo) {
        this.creditCardNo = creditCardNo;
    }

    public String getContactNo() {
        return contactNo;
    }

    public void setContactNo(String contactNo) {
        this.contactNo = contactNo;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    Customer() {}

    public Customer(String firstName, String lastName, LocalDate birthDate, String address, String billingAddress, String contactNo, String creditCardNo, String email) {

        super(firstName, lastName, birthDate);
        this.address = address;
        this.billingAddress = billingAddress;
        this.contactNo = contactNo;
        this.creditCardNo = creditCardNo;
        this.email = email;

    }

    public void addDesktop(Desktop d) { cusDesktop.add(d); }
    public void addLaptop(Laptop l) {
        cusLaptops.add(l);
    }
    public void addComp(Computer c) { cusComputers.add(c); }

    @Override
    public String toString() {
        return String.format("Customer: %s, Address: %s, \nBilling Address: %s, Phone Number: %s, " +
                "Credit Card No: %s, E-mail: %s.", super.toString(), this.address,
                this.billingAddress, this.contactNo, this.creditCardNo, this.email);
    }



}
