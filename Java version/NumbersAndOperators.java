// Import Scanner
import java.util.Scanner;

class NumbersAndOperators {
    //Initialize variables
    long number, number2;
    String operator;

    // Create scanner
    private Scanner sc = new Scanner(System.in);

    // Method to set operators
    void setOperator() {
        System.out.println("First, tell me the type of calculation you want based on the following symbols:\n+ for addition,\n- for subtraction,\n* for multiplication,\n/ for division,\n% for modular calculation and\ns to calculate the square root.");
        operator = sc.nextLine();
        while(!(operator.equals("+") || operator.equals("-") || operator.equals("*") || operator.equals("/") || operator.equals("%") || operator.equals("s"))) {
            System.out.println("Oops! Give me a valid operator:");
            operator = sc.nextLine();
        }
    }

    // Numbers management methods
    void setNumber() {
        while (!sc.hasNextLong()) {
            System.out.println("Please input a valid integer:");
            sc.next();
        }
        number = sc.nextLong();
    }

    private void setNumber2() {
        while (!sc.hasNextLong()) {
            System.out.println("Please input a valid integer:");
            sc.next();
        }
        number2 = sc.nextLong();
    }

    void setNumbers() {
        System.out.println("OK, now give me the first number:");
        setNumber();
        System.out.println("And the second number:");
        setNumber2();
    }

    void divisionCheckZero() {
        while (number2 == 0) {
            System.out.println("You cannot divide by zero. Please try again:");
            setNumber2();
        }
    }
}
