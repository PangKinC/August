package computerShop;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

/**
 * Created by student on 26-Aug-16.
 */
public class GUI {

    static char choice;
    static List<String> computerData = new ArrayList<>();
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
                break;
            case 't':
                break;
            case 's':
                break;
            case 'm':
                break;
            case 'o':
                break;
            case 'l':
                break;
            case 'x':
                break;
        }

    }

    static void computerInput() {

        char compType;
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

}
