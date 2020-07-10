using System;
using static System.Console;

namespace HandlingExceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine("Before Parsing");

            Write("What is your age? ");
            string input = Console.ReadLine();

            try {
                int age = int.Parse(input);
                WriteLine($"You are {age} years old");
            }
            catch (OverflowException){
                WriteLine("Your age is a valid number format but it is either too big or small.");
            }
            catch(FormatException){
                WriteLine("The age you entered is not a valid number format.");
            }
            catch(Exception ex) {
                WriteLine($"Can't parse that input, it's not a integer. {ex.GetType()} {ex.Message}");
            }
            WriteLine("After Parsing");

        }
    }
}
