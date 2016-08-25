package addressBook;

import java.time.LocalDate;

/**
 * Created by student on 23-Aug-16.
 */

public class Contact extends Person{
    private String phoneNumber;
    private String mobileNumber;
    private String email;
    private String facebook;
    private String twitter;

    private Person p;
    private Address a;

    public String getTwitter() {
        return twitter;
    }

    public void setTwitter(String twitter) {
        this.twitter = twitter;
    }

    public String getPhoneNumber() {
        return phoneNumber;
    }

    public void setPhoneNumber(String phoneNumber) {
        this.phoneNumber = phoneNumber;
    }

    public String getMobileNumber() {
        return mobileNumber;
    }

    public void setMobileNumber(String mobileNumber) {
        this.mobileNumber = mobileNumber;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getFacebook() {
        return facebook;
    }

    public void setFacebook(String facebook) {
        this.facebook = facebook;
    }

    public Address getAddress() {
        return a;
    }

    Contact() {}

    public Contact(String firstName, String lastName, LocalDate birthDate, Address a, String phoneNumber, String mobileNumber, String email, String facebook, String twitter) {

        super(firstName, lastName, birthDate);
        this.a = a;
        this.phoneNumber = phoneNumber;
        this.mobileNumber = mobileNumber;
        this.email = email;
        this.facebook = facebook;
        this.twitter = twitter;
    }

    @Override
    public String toString() {
        return String.format("Contact: %s %s " + "\n" + "Home Number: %s, Mobile Number: %s, Email Address: %s, " +
                        "Facebook: %s, Twitter: %s.", super.toString(), this.a, this.phoneNumber, this.mobileNumber, this.email, this.facebook,
                                this.twitter);
    }

}
