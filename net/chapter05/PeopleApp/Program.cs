using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Defining readonly properties
            var sam = new Person {
                Name = "Sam",
                DateOfBirth = new DateTime(1972, 1, 27)
            };

            WriteLine(sam.Origin);
            WriteLine(sam.Greeting);
            WriteLine(sam.Age);

            sam.FavoriteIceCream = "Chocolate Fudge";

            WriteLine($"Sam's favorite ice-cream flavor is {sam.FavoriteIceCream}");

            sam.FavoritePrimaryColor = "Red";

            WriteLine($"Sam's favorite primart color is {sam.FavoritePrimaryColor}");

        }
    }
}
