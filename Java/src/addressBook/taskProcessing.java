package addressBook;

import java.time.LocalDate;
import java.util.List;

import static addressBook.contactGenerator.contacts;

/**
 * Created by student on 23-Aug-16.
 */
public class taskProcessing {
    static void addNewContact(List<String> data){
        Contact temp = new Contact(data.get(0), data.get(1),
                        LocalDate.of(Integer.parseInt(data.get(2)), Integer.parseInt(data.get(3)), Integer.parseInt(data.get(4))),
                                new Address(data.get(5), data.get(6), data.get(7), data.get(8), data.get(9)),
                                data.get(10), data.get(11), data.get(12), data.get(13), data.get(14)
                );

        contacts.add(temp);
    }

    static void listContacts() {
        for (Contact c : contacts) {
            System.out.println(String.format("\n[%s] " + c, contacts.indexOf(c)));
        }
    }

    static int searchContact(String firstName){
        for (Contact c : contacts){
            if (c.getFirstName().contains(firstName)){
                return contacts.indexOf(c);
            }
        }
        return -1;
    }

    static void removeContact(int index) {
        contacts.remove(index);
    }

    static void editContact(int index, List<String> data) {

        contacts.get(index).setFirstName(data.get(0));
        contacts.get(index).setLastName(data.get(1));
        contacts.get(index).setBirthDate(LocalDate.of(
                Integer.parseInt(data.get(2)),
                Integer.parseInt(data.get(3)),
                Integer.parseInt(data.get(4))));
        contacts.get(index).setLineOne(data.get(5));
        contacts.get(index).setLineTwo(data.get(6));
        contacts.get(index).setTown(data.get(7));
        contacts.get(index).setCounty(data.get(8));
        contacts.get(index).setPostcode(data.get(9));
        contacts.get(index).setPhoneNumber(data.get(10));
        contacts.get(index).setMobileNumber(data.get(11));
        contacts.get(index).setEmail(data.get(12));
        contacts.get(index).setFacebook(data.get(13));
        contacts.get(index).setTwitter(data.get(14));

    }

}

