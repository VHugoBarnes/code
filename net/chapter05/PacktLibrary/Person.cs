using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public partial class Person : Object
    {

        // fields 
        public string Name;
        public DateTime DateOfBirth;

        public WondersOfTheAncientWorld FavoriteAncientWonder;

        public WondersOfTheAncientWorld BucketList;

        public List<Person> Children = new List<Person>();

        public const string Species = "Homo Sapiens";

        // read-only fields
        // A beter choice for fields that should not change is to mark them as read-only
        public readonly string HomePlanet = "Earth";
        // **Good practice**: Use read-only fields over the const field 
        // for two important reasons: the value can be calculated or loaded at runtime
        // and can be expressed using any executable statement.

        public readonly DateTime Instantiated;

        // constructors
        public Person(){
            // set default values for fields
            // including read-only fields

            Name = "Unknown";
            Instantiated = DateTime.Now;
        }

        public Person(string initialName, string homePlanet) {
            Name = initialName;
            HomePlanet = homePlanet;
            Instantiated = DateTime.Now;
        }

        // methods 
        public void WriteToConsole()
        {
            WriteLine($"{Name} was born on a {DateOfBirth:dddd}.");
        }

        public string GetOrigin()
        {
            return $"{Name} was born on planet {HomePlanet}.";
        }

        public (string, int) GetFruit(){
            return ("Apples", 5);
        }

        // Naming the fields of a Tuple
        public (string Name, int Number) GetNamedFruit(){
            return (Name: "Apples", Number: 5);
        }

        // Defining and passing parameters to methods
        public string SayHello(){
            return $"{Name} says 'Hello!'";
        }

        public string SayHello(string name){
            return $"{Name} says 'Hello {name}!'";
        }

        // Passing optional parameters and naming arguments
        public string OptionalParameters(
            string command = "Run!",
            double number = 0.0,
            bool active = true) 
            {
                return string.Format(
                    format: "command is {0}, numer is {1}, active is {2}",
                    arg0: command, arg1:number, arg2:active);
            }

        // Controlling how parameters are passed
        public void PassingParameters(int x, ref int y, out int z)
        {
            // out parameters cannot have a default
            // AND must be initialized inside the method
            z = 99;

            // increment each parameter
            x++;
            y+=5;
            z++;

            WriteLine($"In the method: x = {x}, y = {y}, z = {z}");

        }

    }
}
