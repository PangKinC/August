package addressBook;

/**
 * Created by student on 23-Aug-16.
 */
public class Address {
    private String lineOne;
    private String lineTwo;
    private String town;
    private String county;
    private String postcode;

    public String getLineOne() {
        return lineOne;
    }

    public void setLineOne(String lineOne) {
        this.lineOne = lineOne;
    }

    public String getLineTwo() {
        return lineTwo;
    }

    public void setLineTwo(String lineTwo) {
        this.lineTwo = lineTwo;
    }

    public String getTown() {
        return town;
    }

    public void setTown(String town) {
        this.town = town;
    }

    public String getCounty() {
        return county;
    }

    public void setCounty(String county) {
        this.county = county;
    }

    public String getPostcode() {
        return postcode;
    }

    public void setPostcode(String postcode) {
        this.postcode = postcode;
    }

    Address() {}

    public Address(String lineOne, String lineTwo, String town, String county, String postcode) {
        this.lineOne = lineOne;
        this.lineTwo = lineTwo;
        this.town = town;
        this.county = county;
        this.postcode = postcode;
    }

    @Override
    public String toString() {
        return String.format("Address: %s %s, %s, %s. Postcode: %s.", this.lineOne, this.lineTwo, this.town, this.county, this.postcode);
    }
}
