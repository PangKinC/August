package addressBook;

/**
 * Created by student on 23-Aug-16.
 */

public class Contact {
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

    Contact() {}

    public Contact(Person p, Address a, String phoneNumber, String mobileNumber, String email, String facebook, String twitter) {
        this.phoneNumber = phoneNumber;
        this.mobileNumber = mobileNumber;
        this.email = email;
        this.facebook = facebook;
        this.twitter = twitter;
        this.p = p;
        this.a = a;
    }

    @Override
    public String toString() {
        return String.format(" Contact: %s, %s, %s, %s, %s, %s, %s ", this.p, this.a, this.phoneNumber, this.mobileNumber, this.email, this.facebook,
                                this.twitter);
    }
}
