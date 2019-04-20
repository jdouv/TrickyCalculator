// Import Math
import java.lang.Math;

public class Main {
    public static void main(String[] args) {
        System.out.println("\nWelcome to this Tricky Calculator!\nGive me two integers and an operator symbol and the rest is on me.\n\nOK, let's get started!\n\n");

        Calculations c1 = new Calculations();
        c1.basicCalculations();

        System.out.println("\nOK, now let's do something more advanced. We'll do one more calculation and I'll do some magics with the results of these two calculations.");
        Calculations c2 = new Calculations();
        c2.basicCalculations();

        System.out.println("\nPlease note that all your results will be rounded for the purpose of the tricks I promised you.\nNow I'll show you the greatest common divisor of these two results.");

        Calculations gcd = new Calculations();
        if (gcd.greatestCommonDivisor(Math.round(c1.getResult()), Math.round(c2.getResult())) == 0) {
            System.out.println("Well, everything is zero, so there's nothing to show you (also keep in mind that dividing by zero is impossible).");
        } else {
            System.out.println("Well, the greatest common divisor of " + Math.round(c1.getResult()) + " and " + Math.round(c2.getResult()) + " is " + gcd.greatestCommonDivisor(Math.round(c1.getResult()), Math.round(c2.getResult())) + ".\n");
        }
        System.out.println("Now, I'll do some tricks with your second result " + Math.round(c2.getResult()) + ".");
        c2.primeNumber();
        c2.correspondingFibonacci();
        c2.isFibonacci();

        System.out.println("\n\nThat's all for now! If you liked me, subscribe to mathinsanity.com.");
    }
}
