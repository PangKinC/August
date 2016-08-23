package addressBook;

import java.time.LocalDate;
import java.util.ArrayList;
import java.util.List;

/**
 * Created by student on 23-Aug-16.
 */

public class contactGenerator {

    public static Contact contact1 = new Contact(new Person("Kin", "Pang", LocalDate.of(1990, 1, 22)),
            new Address("29", "Walpole Road", "Waltham Forest", "Great Britain", "E17 6PS"),
            "02089325436", "07858374977", "kinchungpang@gmail.com", "Kin Pang", "@ryusuijin");

    public static List<Contact> contacts = new ArrayList<>();

    static void addContact(){
        contacts.add(contact1);
    }
}
