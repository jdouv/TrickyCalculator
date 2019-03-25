class Calculations extends NumbersAndOperators {
    // Initialize variable
    private double result;

    // Basic calculations method with numbers refinement where necessary
    void basicCalculations() {
        setOperator();
        switch (operator) {
            case ("+"):
                setNumbers();
                System.out.println("The sum of these two numbers is " + sum() + ".");
                setResult(sum());
                break;
            case ("-"):
                setNumbers();
                System.out.println("The result of this subtraction is " + subtraction() + ".");
                setResult(subtraction());
                break;
            case ("*"):
                setNumbers();
                System.out.println("The result of this multiplication is " + multiplication() + ".");
                setResult(multiplication());
                break;
            case ("/"):
                setNumbers();
                divisionCheckZero();
                if (division() % 1 == 0) { // Remove decimals if result is integer
                    System.out.printf("The result of this division is %.0f.\n", division());
                } else {
                    System.out.printf("The result of this division is %.2f.\n", division());
                }
                setResult(division());
                break;
            case ("%"):
                setNumbers();
                divisionCheckZero();
                System.out.println("The result of this modular calculation is " + mod() + ".");
                setResult(mod());
                break;
            case ("s"):
                System.out.println("Great! Now give me a number for this square root calculation:");
                setNumber();
                while (number < 0) {
                    System.out.println("You cannot calculate the square root of a negative number. Please try again:");
                    setNumber();
                }
                if (sqrt() % 1 == 0) { // Remove decimals if result is integer
                    System.out.printf("The square root of %d is %.0f.\n",number, sqrt());
                } else {
                    System.out.printf("The square root of %d is %.2f.\n",number, sqrt());
                }
                setResult(sqrt());
                break;
            default:
                System.out.println("Oops! Something happened. Please restart me.");
                break;
        }
    }

    // The "substantial" calculations methods for managing and refining numbers
    private long sum() {
        return number + number2;
    }

    private long subtraction() {
        return number - number2;
    }

    private long multiplication() {
        return number * number2;
    }

    private double division() {
        double x = number; // Numbers converted to doubles if return is decimal
        double y = number2;
        if (y == 0) { // "Emergency" result if input check fails (since there is no division with zero)
            return 0;
        }
        return x / y;
    }

    private long mod() {
        if (number2 == 0) { // "Emergency" result if input check fails (since there is no division with zero)
            return 0;
        }
        return number % number2;
    }

    private double sqrt() {
        return Math.sqrt(number);
    }

    private void setResult(double result) {
        this.result = result;
    }

    double getResult() {
        return result;
    }

    // Advanced methods
    long greatestCommonDivisor(long a, long b) {
        if (b == 0) {
            return Math.abs(a);
        }
        return greatestCommonDivisor(b, a % b);
    }

    void primeNumber() {
        if (Math.abs(Math.round(result)) == 0 || Math.abs(Math.round(result)) == 1) {
            System.out.println(Math.abs(Math.round(result)) + " is not a prime number.");
        } else {
            long tmp;
            boolean prime = true;
            for (long i=2;i<=Math.abs(Math.round(result))/2;i++) {
                tmp = Math.abs(Math.round(result)) % i;
                if (tmp == 0) {
                    prime = false;
                    break;
                }
            }
            if (prime) {
                System.out.println("Well, " + Math.abs(Math.round(result)) + " is a prime number.");
            } else {
                System.out.println("Well, " + Math.abs(Math.round(result)) + " is not a prime number.");
            }
        }
    }

    void correspondingFibonacci() {
        long a = 0;
        long b = 1;
        long result = 0;

        if (Math.abs(Math.round(this.result)) == 0 || Math.abs(Math.round(this.result)) == 1) {
            System.out.println("The corresponding Fibonacci number of " + Math.abs(Math.round(this.result)) + " is " + Math.abs(Math.round(this.result)) + " itself.");
        } else {
            for (long i=2;i<=Math.abs(Math.round(this.result));i++) {
                result = a + b;
                a = b;
                b = result;
            }
            System.out.println("The corresponding Fibonacci number of " + Math.abs(Math.round(this.result)) + " is " + result + ".");
        }
    }

    void isFibonacci() {
        long a = 0;
        long b = 1;
        long result = 0;

        while (result < Math.abs(Math.round(this.result))) {
            result = a + b;
            a = b;
            b = result;
        }

        if (result == Math.abs(Math.round(this.result))) {
            System.out.println(Math.abs(Math.round(this.result)) + " is a Fibonacci number.");
        } else {
            System.out.println(Math.abs(Math.round(this.result)) + " is not a Fibonacci number.");
        }
    }
}