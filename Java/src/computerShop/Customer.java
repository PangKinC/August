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
    private long creditCardNo;
    private String contactNo;
    private String email;
    private List<Laptop> cusLaptops = new ArrayList<>();
    private List<Desktop> cusDesktop = new ArrayList<>();

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

    public long getCreditCardNo() {
        return creditCardNo;
    }

    public void setCreditCardNo(long creditCardNo) {
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

    public Customer(String firstName, String lastName, LocalDate birthDate, String address, String billingAddress, String contactNo, long creditCardNo, String email) {

        super(firstName, lastName, birthDate);
        this.address = address;
        this.billingAddress = billingAddress;
        this.contactNo = contactNo;
        this.creditCardNo = creditCardNo;
        this.email = email;

    }

    public void addLaptop(Laptop l) {
        cusLaptops.add(l);
    }

    @Override
    public String toString() {
        return String.format("Customer: %s, %s, %s, %s, %s, %s.", super.toString(), this.address, this.billingAddress, this.contactNo, this.creditCardNo, this.email);
    }



}
