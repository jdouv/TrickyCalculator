import math


class Calculations:

    # Method to set operators
    def set_operator(self):
        self.operator = input("First, tell me the type of calculation you want based on the following symbols:\n+ for "
                              "addition,\n- for subtraction,\n* for multiplication,\n/ for division,\n% for modular "
                              "calculation and\ns to calculate the square root.\n")
        while not (self.operator == "+" or self.operator == "-" or self.operator == "*" or self.operator == "/" or
                   self.operator == "%" or self.operator == "s"):
            self.operator = input("Oops! Give me a valid operator: ")

    # Numbers management methods
    def set_numbers(self):
        self.set_number(input("OK, now give me the first number: "))
        self.set_number2(input("And the second number: "))

    def set_number(self, number):
        while not number.isdigit():
            number = int(input("Please input a valid integer: "))
        self.number = int(number)

    def set_number2(self, number2):
        while not number2.isdigit():
            number2 = int(input("Please input a valid integer: "))
        self.number2 = int(number2)

    def division_check_zero(self):
        while self.number2 == 0:
            self.number2 = (input("You cannot divide by zero. Please try again: "))

    # Basic calculations method with numbers refinement where necessary
    def basic_calculations(self):
        self.set_operator()
        if self.operator is "+":
            self.set_numbers()
            print("The sum of these two numbers is " + str(self.calc_sum()) + ".")
            self.result = self.calc_sum()
        elif self.operator is "-":
            self.set_numbers()
            print("The result of this subtraction is " + str(self.subtraction()) + ".")
            self.result = self.subtraction()
        elif self.operator is "*":
            self.set_numbers()
            print("The result of this multiplication is " + str(self.multiplication()) + ".")
            self.result = self.multiplication()
        elif self.operator is "/":
            self.set_numbers()
            self.division_check_zero()
            if self.division() % 1 == 0:  # Remove decimals if result is integer
                print(f"The result of this division is {round(self.division())}.\n")
            else:
                print(f"The result of this division is {self.division():.2f}.\n")
            self.result = self.division()
        elif self.operator is "%":
            self.set_numbers()
            self.division_check_zero()
            print("The result of this modular calculation is " + str(self.mod()) + ".")
            self.result = self.mod()
        elif self.operator is "s":
            self.set_number(input("Great! Now give me a number for this square root calculation: "))
            while int(self.number) < 0:
                self.number = (input("You cannot calculate the square root of a negative number. Please try again: "))
            if math.sqrt(int(self.number)) % 1 == 0:  # Remove decimals if result is integer
                print(f"The square root of {self.number} is {round(math.sqrt(int(self.number)))}.\n")
            else:
                print(f"The square root of {self.number} is {math.sqrt(int(self.number)):.2f}.\n")
            self.result = math.sqrt(int(self.number))
        else:
            print("Oops! Something happened. Please restart me.")

    # The "substantial" calculations methods for managing and refining numbers
    def calc_sum(self):
        return self.number + self.number2

    def subtraction(self):
        return int(self.number) - int(self.number2)

    def multiplication(self):
        return int(self.number) * int(self.number2)

    def division(self):
        x = int(self.number)  # Numbers converted to doubles if return is decimal
        y = int(self.number2)
        if y == 0:  # "Emergency" result if input check fails (since there is no division with zero)
            return 0
        return x / y

    def mod(self):
        if self.number2 == 0:  # "Emergency" result if input check fails (since there is no division with zero)
            return 0
        return self.number % self.number2

    # Advanced methods
    def greatest_common_divisor(self, a, b):
        if b is 0:
            return abs(a)
        return self.greatest_common_divisor(b, a % b)

    def prime_number(self):
        if abs(round(self.result)) == 0 or abs(round(self.result)) == 1:
            print(str(abs(round(self.result))) + " is not a prime number.")
        else:
            prime = True
            for i in range(2, int(abs(round(self.result)) / 2)):
                tmp = abs(round(self.result)) % i
                if tmp is 0:
                    prime = False
                    break

            if prime:
                print("Well, " + str(abs(round(self.result))) + " is a prime number.")
            else:
                print("Well, " + str(abs(round(self.result))) + " is not a prime number.")

    def corresponding_fibonacci(self):
        a = 0
        b = 1
        result = 0

        if abs(round(self.result)) is 0 or abs(round(self.result)) is 1:
            print("The corresponding Fibonacci number of " + str(abs(round(self.result))) + " is " + str(
                abs(round(self.result))) + " itself.")
        else:
            for i in range(len((2, abs(round(self.result))))):
                result = a + b
                a = b
                b = result

            print("The corresponding Fibonacci number of " + str(abs(round(self.result))) + " is " + str(result) + ".")

    def is_fibonacci(self):
        a = 0
        b = 1
        result = 0

        while result < abs(round(self.result)):
            result = a + b
            a = b
            b = result

        if result is abs(round(self.result)):
            print(str(abs(round(self.result))) + " is a Fibonacci number.")
        else:
            print(str(abs(round(self.result))) + " is not a Fibonacci number.")
