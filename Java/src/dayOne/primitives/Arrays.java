package dayOne.primitives;

/**
 * Created by student on 22-Aug-16.
 */
public class Arrays {

    public static void main(String[] args){

        int[] test = { 3, 2, 2, 6, 9, 7, 8, 10};
        int[] testTwo = { 0, 2, 3, 1, 5 };
        int[] testThree = {1, 0, 2};

        //maxEndThree(test);
        //countsEven(test);
        //bigDiff(test);
        //sumThirteen(test);
        sumSixSeven(test);
        //System.out.println(hasTwoTwo(test));
        //System.out.println(hasTwoThree(test));

    }

    static void example(){
        int monthDays[] = { 31, 28, 31, 30, 31, 30,
                31, 31, 30, 31, 30, 31 };

        int twoDimen[][] = new int [4][5];
        int i, j, k = 0;

        for (i = 0; i < 4; i++){
            for (j = 0; j <  5; j++){
                twoDimen[i][j] = k;
                k++;
            }
        }

        int threeDimen[][][] = new int [3][4][5];

        int a, b, c = 0;

        for (a = 0; a < 3; a++){
            for (b = 0; b < 4; b++){
                for (c = 0; c < 5; c++){
                    threeDimen[a][b][c] = a * b * c;
                }
            }
        }
    }

    static boolean firstLastSix(int[] numbers) {
        return (numbers[0] == 6 || numbers[numbers.length - 1] == 6);
    }

    static boolean sameFirstLast(int[] numbers) {
        return (numbers[0] == numbers[numbers.length - 1]);
    }

    static boolean commonEnd(int[] numOne, int[] numTwo){
        return (numOne[0] == numTwo[0] || numOne[numOne.length - 1] == numTwo[numTwo.length - 1]);
    }

    static void maxEndThree(int[] numbers){

        int[] test = {0, 0, 0};

        if (numbers[0] > numbers[numbers.length - 1]) {
            test[0] = numbers[0];
            test[1] = numbers[0];
            test[2] = numbers[0];
        }

        else if (numbers[numbers.length - 1] > numbers[0]){
            test[0] = numbers[numbers.length - 1];
            test[1] = numbers[numbers.length - 1];
            test[2] = numbers[numbers.length - 1];
        }

        System.out.println(String.format("{ %s, %s, %s }", test[0], test[1], test[2]));
    }

    static boolean hasTwoThree(int[] numbers){
        return (numbers[0] == 2 || numbers[0] == 3 || numbers[1] == 2 || numbers[1] == 3);
    }

    static void countsEven(int[] numbers){
        int even = 0;
        for (int i = 0; i < numbers.length; i++){
            if (numbers[i] % 2 == 0){
                even++;
            }
        }
        System.out.println(String.format("Number of evens in the array %s.", even));
    }

    static void bigDiff(int[] numbers) {

        int smallest = numbers[0];
        int biggest = numbers[0];
        int result = 0;

        for (int i = 0; i < numbers.length; i++) {
            smallest = Math.min(smallest, numbers[i]);
            biggest = Math.max(biggest, numbers[i]);
        }

        result = biggest - smallest;

        System.out.println(String.format("The biggest value is %s, smallest is %s, and the difference is %s.", biggest, smallest, result));
    }

    static void sumThirteen(int[] numbers) {

        int result = 0;

        for (int i = 0; i < numbers.length; i++) {
            result += numbers[i];

            if (numbers[i] == 13){
                result -= 13;
                i = numbers.length;
                System.out.println("13 was found!");
            }
            else if (numbers.length == 0){
                result = 0;
                System.out.println("Sum is 0, because the array is empty.");
            }
        }
        System.out.println(String.format("The sum of the array is %s.", result));
    }

    static void sumSixSeven(int[] numbers) {
        int calc, result = 0;
        boolean inBetween = false;


        for (int i = 0; i < numbers.length; i++){
            calc = numbers[i];

            if (calc == 6 && !inBetween) { inBetween = true; }
            else if (calc == 7 && inBetween) { inBetween = false; }
            else if (!inBetween) { result += calc; }
        }
        System.out.println(String.format("The sum of all numbers not between 6 and 7 is %s.", result));
    }

    static boolean hasTwoTwo(int[] numbers){

        for (int i = 0; i < numbers.length; i++){
            if (numbers[i] == 2 && numbers[i+1] == 2){
                return true;
            }
        }
        return false;
    }
}

