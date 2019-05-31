from Calculations import *


print("\nWelcome to this Tricky Calculator!\nGive me two integers and an operator symbol and the rest is on me.\n\nOK, "
      "let's get started!\n\n")

c1 = Calculations()
c1.basic_calculations()

print("\nOK, now let's do something more advanced. We'll do one more calculation and I'll do some magics with the "
      "results of these two calculations.")

c2 = Calculations()
c2.basic_calculations()

print("\nPlease note that all your results will be rounded for the purpose of the tricks I promised you.\nNow I'll show"
      " you the greatest common divisor of these two results.")

gcd = Calculations()
if gcd.greatest_common_divisor(round(c1.result), round(c2.result)) == 0:
    print("Well, everything is zero, so there's nothing to show you (also keep in mind that dividing by zero is "
          "impossible).")
else:
    print("Well, the greatest common divisor of " + str(round(c1.result)) + " and " + str(round(c2.result)) + " is " +
          str(gcd.greatest_common_divisor(round(c1.result), round(c2.result))) + ".\n")

print("Now, I'll do some tricks with your second result " + str(round(c2.result)) + ".")
c2.prime_number()
c2.corresponding_fibonacci()
c2.is_fibonacci()

print("\n\nThat's all for now! If you liked me, subscribe to mathinsanity.com.")
