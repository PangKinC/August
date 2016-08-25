package dayTwo.OOP;

import static dayTwo.OOP.peopleGenerator.people;

/**
 * Created by student on 23-Aug-16.
 */
public class Program {
    public static void main(String[] args){

        /*for(Person p : people){
            System.out.println(p);
        }*/

        //commandGUI.display();
        peopleGenerator.addPeople();
        new welcomeWindow();

    }
}
