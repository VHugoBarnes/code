using System;

namespace Variables{
    class Program{
        static void Main(string[] args){

            object height = 1.88; // stores a double in an object
            object name = "Keko"; // stores a string in an object

            Console.WriteLine($"{name} is {height} meters tall.");

            // int length = name.Length; // gives compiler error
            int length2 = ((string)name).Length; // tell compiler it is a string

            Console.WriteLine($"{name} has {length2} characters.");

            // storing a string in a dynamic object
            dynamic anotherName = "Malia";

            // this compiles but would throw an exception at run-time
            // if you later store a data type that does not have a property
            // named Length
            int length = anotherName.Length;

            Console.WriteLine($"{anotherName} has {length} characters.");

            int population = 6_000_000; // 66 millon in UK
            double weight = 1.88; // in killograms
            decimal price = 4.99M; // in pounds sterling
            string fruit = "Apples"; // string uses double quotes
            char letter = 'Z'; // char use single quotes
            bool happy = true; // booleans have value of true or false

            

        }
    }
}
