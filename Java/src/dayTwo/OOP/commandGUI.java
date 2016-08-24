package dayTwo.OOP;

import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

import static dayTwo.OOP.peopleGenerator.people;

/**
 * Created by student on 23-Aug-16.
 */

public class commandGUI {

    static Scanner input = new Scanner(System.in);

    static void display(){
        int choice;

        do {
            System.out.println("Welcome to the Employee Database.");
            System.out.println("1. Add an Employee.");
            System.out.println("2. Edit an Employee.");
            System.out.println("3. Remove an Employee.");
            System.out.println("4. List all Employees.");
            System.out.println("5. Search by First Name.");
            System.out.println("6. Exit Program");
            System.out.println();
            System.out.println("Enter a value been (1-6): ");

            choice = input.nextInt();

        } while (choice < 1 || choice > 6);

        int index;
        List<String> tempData = new ArrayList<>();

        switch (choice) {
            case 1:
                tempData = inputScreen();
                taskProcessing.createEmployee(tempData);
                display();
                break;
            case 2:
                index = findFirstName();
                tempData = inputScreen();
                taskProcessing.editDetails(index, tempData);
                display();
                break;
            case 3:
                taskProcessing.removeEmployee(requestIndex());
                display();
                break;
            case 4:
                taskProcessing.printAll();
                display();
                break;
            case 5:
                index = findFirstName();
                System.out.println(people.get(index));
                display();
                break;
            case 6:
                break;
        }
    }

    static List<String> inputScreen(){

        List<String> employeeData = new ArrayList<>();
        input.nextLine();

        System.out.println("Enter First Name: ");
        employeeData.add(input.nextLine());

        System.out.println("Enter Last Name: ");
        employeeData.add(input.nextLine());

        System.out.println("Enter the Height: ");
        employeeData.add(input.nextLine());

        System.out.println("Enter the Weight: ");
        employeeData.add(input.nextLine());

        System.out.println("Enter D.O.B (YYYY/MM/DD): ");
        String dob = input.nextLine();
        String[] dobData = dob.split("/");

        for (int i = 0; i < dobData.length; i++){
            employeeData.add(dobData[i]);
        }

        System.out.println("Enter Gender M / F: ");
        employeeData.add(input.nextLine());

        //System.out.println("Enter Blood Type: A / B / AB / O / RHESUS_NEG");
        //employeeData.add(input.nextLine());

        System.out.println("Enter Employee Position: ");
        employeeData.add(input.nextLine());

        System.out.println("Enter Hire Date (YYYY/MM/DD): ");
        String hire = input.nextLine();
        String[] hireData = hire.split("/");

        for (int i = 0; i < hireData.length; i++){
            employeeData.add(hireData[i]);
        }

        return employeeData;
    }

    static int findFirstName() {
        System.out.print("Enter first name of employee: ");
        String firstName = input.next();
        return taskProcessing.searchPerson(firstName);
    }

    static int requestIndex() {
        System.out.print("Enter Employee index to remove: ");
        return input.nextInt();
    }
}
