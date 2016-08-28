package computerShop;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import static computerShop.Generator.computers;
import static computerShop.Generator.desktops;
import static computerShop.Generator.laptops;

/**
 * Created by student on 26-Aug-16.
 */
public class GUI {

    static char choice;
    static char compType;
    static double cpuSpeed;
    static int index;
    static List<String> computerData = new ArrayList<>();
    static List<String> customerData = new ArrayList<>();
    static Scanner input = new Scanner(System.in);

    static void display() {

        do {

            System.out.println();
            System.out.println("Manage Computers Menu.");
            System.out.println();
            System.out.println("C - Add New Computer.");
            System.out.println("T - Add New Customer.");
            System.out.println("S - Search for Computer.");
            System.out.println("M - Match Customer Computer.");
            System.out.println("O - Order Computer Price");
            System.out.println("L - List Customers CPU");
            System.out.println("X - Exit Program");
            System.out.println();
            System.out.print("Choose an option from the above list with respective key: ");

            choice = input.nextLine().toLowerCase().charAt(0);

        } while (choice != 'c' && choice != 't' && choice != 's' && choice != 'm'
                    && choice != 'o' && choice != 'l' && choice != 'x');

        switch (choice) {
            case 'c':
                computerInput();
                display();
                break;
            case 't':
                customerInput();
                display();
                break;
            case 's':
                index = searchCPUSpeed();
                System.out.println("\n" + computers.get(index));
                input.nextLine();
                display();
                break;
            case 'm':
                break;
            case 'o':
                Processor.listComputers();
                display();
                break;
            case 'l':
                Processor.listCustomers();
                display();
                break;
            case 'x':
                break;
        }

    }

    static void computerInput() {

        computerData = new ArrayList<>();

        System.out.println("Please choose D for Desktop or L for Laptop.");
        compType = input.next().toLowerCase().charAt(0);
        input.nextLine();

        System.out.print("Enter the model of the computer: ");
        computerData.add(input.nextLine());

        System.out.print("Enter the CPU model: ");
        computerData.add(input.nextLine());

        System.out.print("Enter the CPU speed: ");
        computerData.add(input.nextLine());

        System.out.print("Enter the GPU model: ");
        computerData.add(input.nextLine());

        System.out.print("Enter the RAM amount: ");
        computerData.add(input.nextLine());

        System.out.print("Enter the Hard Drive capacity: ");
        computerData.add(input.nextLine());

        System.out.print("Enter the price for the computer: ");
        computerData.add(input.nextLine());

        if (compType == 'd') {
            desktopInput();
        }

        else if (compType == 'l') {
            laptopInput();
        }

    }

    static void desktopInput() {

        System.out.print("Add a keyboard for the desktop: ");
        computerData.add(input.nextLine());

        System.out.print("Add a monitor for the desktop: ");
        computerData.add(input.nextLine());

        System.out.print("Add a mouse for the desktop: ");
        computerData.add(input.nextLine());

        System.out.print("Add some speakers for the desktop: ");
        computerData.add(input.nextLine());

        Processor.addNewDesktop(computerData);

    }

    static void laptopInput() {

        System.out.print("Enter the battery life of the laptop: ");
        computerData.add(input.nextLine());

        System.out.print("Enter the weight of the laptop: ");
        computerData.add(input.nextLine());

        Processor.addNewLaptop(computerData);

    }

    static void customerInput() {

        customerData = new ArrayList<>();

        System.out.print("Enter the first name of the customer: ");
        customerData.add(input.nextLine());

        System.out.print("Enter the last name of the customer: ");
        customerData.add(input.nextLine());

        System.out.print("Enter the D.O.B (YYYY/MM/DD) of the customer: ");
        String dob = input.nextLine();
        String[] dobData = dob.split("/");

        for (int i = 0; i < dobData.length; i++) {
            customerData.add(dobData[i]);
        }

        System.out.print("Enter the address of the customer: ");
        customerData.add(input.nextLine());

        System.out.print("Enter the billing address of the customer: ");
        customerData.add(input.nextLine());

        System.out.print("Enter the phone number of the customer: ");
        customerData.add(input.nextLine());

        System.out.print("Enter the credit card number of the customer: ");
        customerData.add(input.nextLine());

        System.out.print("Enter the e-mail address of the customer: ");
        customerData.add(input.nextLine());

        Processor.addNewCustomer(customerData);
        customerMatch();
    }

    static void customerMatch() {

        System.out.print("Does the customer want to buy a Desktop (D) or Laptop (L)? ");
        compType = input.next().toLowerCase().charAt(0);
        input.nextLine();


        if (compType == 'd') {
            System.out.print("What is the CPU speed of the Desktop the customer would like to buy? ");
            cpuSpeed = input.nextDouble();
            Processor.buyDesktop(cpuSpeed);
            input.nextLine();
        }

        else if (compType == 'l') {
            System.out.print("What is the CPU speed of the Laptop the customer would like to buy? ");
            cpuSpeed = input.nextDouble();
            Processor.buyDesktop(cpuSpeed);
            input.nextLine();
        }
    }

    static int searchCPUSpeed(){
        System.out.print("\nEnter the CPU Speed of the desktop or laptop: ");
        cpuSpeed = input.nextDouble();
        return Processor.searchComputer(cpuSpeed);
    }

}
