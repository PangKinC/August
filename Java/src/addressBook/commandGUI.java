package addressBook;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by student on 23-Aug-16.
 */

public class commandGUI {

    static Scanner input = new Scanner(System.in);

    static void display(){
        int choice;

        do {
            System.out.println("This is your Contacts.");
            System.out.println("1. Add Contact.");
            System.out.println("2. Edit Contact");
            System.out.println("3. Remove Contact");
            System.out.println("4. List all Contacts");
            System.out.println("5. Search Contact by First Name");
            System.out.println("6. Exit Program");
            System.out.println();
            System.out.println("Enter a value been (1-6): ");

            choice = input.nextInt();

        } while (choice < 1 || choice > 6);

        List<String> tempData = new ArrayList<>();

        switch (choice) {
            case 1:
                tempData = inputScreen();
                taskProcessing.addNewContact(tempData);
                display();
            case 2:
            case 3:
            case 4:
                taskProcessing.listContacts();
                display();
            case 5:
            case 6:
                break;
        }
    }

    static List<String> inputScreen(){

        List<String> contactsData = new ArrayList<>();
        input.nextLine();

        System.out.println("Enter First Name: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter Last Name: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter D.O.B (YYYY/MM/DD): ");
        String dob = input.nextLine();
        String[] dobData = dob.split("/");

        for (int i = 0; i < dobData.length; i++){
            contactsData.add(dobData[i]);
        }

        System.out.println("Enter first line of address: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter second line of address: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter the town: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter the county: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter the postcode: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter home number: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter mobile number: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter a email address: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter Facebook login: ");
        contactsData.add(input.nextLine());

        System.out.println("Enter @Twitter login: ");
        contactsData.add(input.nextLine());

        return contactsData;
    }
}
