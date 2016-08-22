package dayOne.primitives;

/**
 * Created by student on 22-Aug-16.
 */
public class Arrays {

    public static void main(String[] args){
        int[] test = { 2, 3 };
        int[] testTwo = { 0, 2, 3, 1, 5 };

        //maxEndThree(test);
        System.out.println(hasTwoThree(test));
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


}

