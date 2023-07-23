using System;
// The `using` directive is similar to the `require` keyword when I make Ruby programs.
// This namespace adds fundemental classes, data types and functions common to C# programs.

namespace CalculatorApp
{
// It's good to think of a namespace in C# programs as a container for your code elements.
// These elements will include classes, interfaces, enums, and even other namespaces.

    class Calculator
    {
    // This brings us to our first class: `Program`. This serves as the entry point for the entire app.
    // Once the app executes, the `Main` method below is triggered as its starting point following entry.

        static void Main(string[] args)  // `static void` indicates this is a static method, belonging to the class itself and not its instances.
        {                                // The logic for our calculator app will continue to be built here...

            Console.WriteLine("Basic Calculator");  // These should be familiar, Erika.
            Console.WriteLine("----------------");  // They're clearly print statements (or `puts`, considering the new line).

            Console.Write("Enter the first number: ");  // You can think of `Write` as the Ruby equivalent `Print`.
            double num1 = Convert.ToDouble(Console.ReadLine());  // `Console.ReadLine()` gets user value. We from string to double for decimal plaes.

            Console.Write("Enter the operator (+, -, *, /): ");  // User selects one of four operators.
            char op = Console.ReadLine()[0];  // `char` requires an index, so we're selecting index 0 from the user's input (not as intuitive as Ruby).

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = 0;  // Give the operation a default value of '0' prior to user input.

            switch (op)
            {
            // This is the starting point of the switch statement that focuses on the variable op before moving onto the matching case block.
            // The case block is intuitive enough, assigning `result` based on the chosen operator and the `num1` / `num1` variables.

                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    if (num2 != 0)  // There is one special case with an `if/else` pattern (because you can't divide by 0).
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Cannot divide by zero.");
                        return;
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operator.");  // Default statement for the case block if the above operators are not chosen.
                    return;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
