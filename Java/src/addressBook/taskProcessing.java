package addressBook;

import java.time.LocalDate;
import java.util.List;

import static addressBook.contactGenerator.contacts;

/**
 * Created by student on 23-Aug-16.
 */
public class taskProcessing {
    static void addNewContact(List<String> data){
        Contact temp = new Contact (
                new Person(data.get(0), data.get(1),
                        LocalDate.of(Integer.parseInt(data.get(2)), Integer.parseInt(data.get(3)), Integer.parseInt(data.get(4)))),
                                new Address(data.get(5), data.get(6), data.get(7), data.get(8), data.get(9)),
                                data.get(10), data.get(11), data.get(12), data.get(13), data.get(14)
                );

        contacts.add(temp);
    }

    static void listContacts() {
        for (Contact c : contacts) {
            System.out.println(c);
        }
    }
}

