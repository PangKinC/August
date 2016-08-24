package addressBook;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import static addressBook.contactGenerator.contacts;

/**
 * Created by student on 23-Aug-16.
 */

public class GUI {

    static Scanner input = new Scanner(System.in);

    static void display(){
        int choice;

        do {
            System.out.println();
            System.out.println("Manage Your Contacts Here.");
            System.out.println();
            System.out.println("1. Add Contact.");
            System.out.println("2. Edit Contact");
            System.out.println("3. Remove Contact");
            System.out.println("4. List All Contacts");
            System.out.println("5. Search Contacts");
            System.out.println("6. Exit Program");
            System.out.println();
            System.out.print("Choose an option from the above list (value 1-6): ");

            choice = input.nextInt();

        } while (choice < 1 || choice > 6);

        int index;
        List<String> tempData;

        switch (choice) {

            case 1:
                System.out.println("\nPlease enter in the coming fields details of the new contact.");
                tempData = inputScreen();
                Processor.addNewContact(tempData);
                display();
                break;
            case 2:
                System.out.println("\nTo edit the details of a contact, please follow instructions below: ");
                index = searchFirstName();
                tempData = inputScreen();
                Processor.editContact(index, tempData);
                display();
                break;
            case 3:
                System.out.println("\nYou have chosen to delete a contact, please follow instructions below: ");
                Processor.removeContact(requestIndex());
                System.out.println("\n... Contact has been removed from the database.");
                display();
                break;
            case 4:
                System.out.println("\nHere is the list of all your contacts: ");
                Processor.listContacts();
                display();
                break;
            case 5:
                System.out.println("\nYou have chosen to search for a contact, please follow instructions below: ");
                index = searchFirstName();
                System.out.println("\n" + contacts.get(index));
                display();
                break;
            case 6:
                break;
        }
    }

    static List<String> inputScreen(){

        List<String> contactsData = new ArrayList<>();
        input.nextLine();

        System.out.println();

        System.out.print("Enter First Name: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter Last Name: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter D.O.B (YYYY/MM/DD): ");
        String dob = input.nextLine();
        String[] dobData = dob.split("/");

        for (int i = 0; i < dobData.length; i++){
            contactsData.add(dobData[i]);
        }

        System.out.print("Enter first line of address: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter second line of address: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter the town: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter the county: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter the postcode: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter home number: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter mobile number: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter a email address: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter Facebook details: ");
        contactsData.add(input.nextLine());

        System.out.print("Enter @Twitter details: ");
        contactsData.add(input.nextLine());

        System.out.println("\nContact has been added / changed.");

        return contactsData;
    }

    static int searchFirstName(){
        System.out.print("\nEnter the First Name of the Contact: ");
        String firstName = input.next();
        System.out.println("\nContact was found!");
        return Processor.searchContact(firstName);
    }

    static int requestIndex() {
        System.out.print("\nEnter the index number of a contact to remove: ");
        return input.nextInt();
    }
}
