using System;

namespace MathLibraryProject {
    class Program {
        static void Main(string[] args) {
            // Var is implicit and has to return value
            var a = Math.Add("1", "2"); // Add 2 Strings
            var b = Math.Add(1, 2); // Add 2 integers
            var c = Math.Add(1.0m, 2.0m); // Add 2 decimals
            var d = Math.Add(85477580843434223, 1234567893232343); // Add 2 Long
            var e = Math.Mult(1, 2);
            /////////////////////////////////////////////////////////////////////////////////

            // All 4 of the Add methods in Math.cs do the same functionality of adding 2
            // numbers together, with the only difference being that the 2 numbers being added
            // together can both be integers, decimal, long or string.

            // For example, there can be Math.Add(1, 2) which adds 2 integers together or
            // there can be Math.Add("1", "2") which adds 2 strings together.

            // Polymorphism allows each of the methods to work the same & have the same name
            // at the same time. Instead of having to have 4 separate methods with different
            // names to add the 4 methods in Math.cs, there can only be one Method name which
            // takes care of the Add functionality.

            // The question arises of how does the program know which Add method to select.
            // This is taken care of because the system matches the method to the type of the
            // numbers entered. For example, if both numbers entered were decimals, the second
            // Add method would be chosen.

        }
    }
}
