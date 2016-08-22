package dayOne.primitives;

import java.io.IOException;
import java.util.Scanner;

/**
 * Created by student on 22-Aug-16.
 */
public class ControlStatements {

    static Scanner input = new Scanner(System.in);

    public static void main(String[] args){
        binaryCalc();
    }

    static void seasonCheck() {
        int month = 4;
        String season;

        if (month == 12 || month == 1 || month == 2) { season = "Winter"; }
        else if (month == 3 || month == 4 || month == 5) { season = "Spring"; }
        else if (month == 6 || month == 7 || month == 8) { season = "Summer"; }
        else if (month == 9 || month == 10 || month == 11) { season = "Autumn"; }
        else { season = "Bogus Month"; }

        System.out.println("April is in the " + season);
    }

    static void numberCheck() {

        System.out.print("Please enter a number, from 1-2000: ");
        int num = input.nextInt();

        if (num < 100) { System.out.println("Your number is equal to 100."); }
        else if (num < 500) { System.out.println("Your number is equal to 500."); }
        else if (num < 1000) { System.out.println("Your number is equal to 1000."); }
        else { System.out.println("Your number is beyond our scope."); }

    }

    static void characterCheck() {
        System.out.println("Please enter a character: ");
        char c = input.next().charAt(0);

        if (Character.isUpperCase(c)) { System.out.println("Your character is a uppercase."); }
        else if (Character.isLowerCase(c)) { System.out.println("Your character is a lowercase."); }
        else if (Character.isDigit(c)) { System.out.println("Your character is a number."); }
        else { System.out.println("Your character is a not a letter or number."); }

    }

    static void iceCreamSize() {
        try {
            char size;
            do {
                System.out.println("Please type in the size of ice cream you would like: ");
                System.out.println("1. Small");
                System.out.println("2. Medium");
                System.out.println("3. Large");
                System.out.println("4. Huge");
                size = (char) System.in.read();
            } while (size < '1' || size > '4');

            switch (size){

                case '1':
                    System.out.println("The price is £1.25");
                    break;
                case '2':
                    System.out.println("The price is £2.25");
                    break;
                case '3':
                    System.out.println("The price is £3.25");
                    break;
                case '4':
                    System.out.println("The price is £4.00");
                    break;
                default:
                    break;
            }
        } catch (IOException e) { System.out.println(e.getMessage()); }
    }

    static void Menu() {
        try {
            char choice;
            do {
                System.out.println("Helper Menu: ");
                System.out.println("1. if");
                System.out.println("2. switch");
                System.out.println("3. while");
                System.out.println("4. do-while");
                choice = (char) System.in.read();
            } while (choice < '1' || choice > '4');

            switch(choice){
                case '1':
                    System.out.println("if statement use boolean conditions");
                    break;
                case '2':
                    System.out.println("switch statement use constant expressions to compare.");
                    break;
                case '3':
                    System.out.println("while is a simple loop, use a boolean condition.");
                    break;
                case '4':
                    System.out.println("Just keep doing it! BOOM!");
                    break;
            }
        } catch (IOException e) { System.out.println(e.getMessage()); }
    }

    static void Calculator() {

        int numOne, numTwo;
        char operator;
        int result;

        System.out.println("Please enter the first value: ");
        numOne = input.nextInt();

        System.out.println("Please enter the second value: ");
        numTwo = input.nextInt();

        System.out.println("Please enter a operator: ");
        operator = input.next().charAt(0);

        switch (operator){
            case '+':
                result = numOne + numTwo;
                System.out.println("The result is: " + result);
                break;
            case '-':
                result = numOne - numTwo;
                System.out.println("The result is: " + result);
                break;
            case '*':
                result = numOne * numTwo;
                System.out.println("The result is: " + result);
                break;
            case '/':
                result = numOne / numTwo;
                System.out.println("The result is: " + result + ".");
                break;
            default:
                break;
        }
    }

    static void whileInfinite(){
        int index = 0;

        out:
        while (true){
            int value = ++index;

            System.out.println(value);

            if (value == 5) {
                System.out.println("Found it!");
                break out;
            }

            if (value == 10) {
                System.out.println(value);
                break;
            }
        }
    }

    static void forLoopTest() {
        String[] data = {"This", "is", "a", "String."};

        for (int i = 0; i <= data.length -1; i++) {
            System.out.println(data[i]);
        }

        String result = "";

        for (String s : data){
            result += String.format(s + " ");
        }

        System.out.println(result);
    }

static void binaryCalc() {
    int result = 0;
    int multiplier = 1;

    System.out.println("Please enter a binary string.");

    String binInput = input.nextLine();

    for (int i = binInput.length() - 1; i >= 0 ; i--){
       if (binInput.charAt(i) == '1')
           result += multiplier;
           multiplier *= 2;
    }
    System.out.println("The decimal value is: " + result + ".");








}


}
