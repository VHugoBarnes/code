using System;
using System.Collections.Generic;

namespace Packt.Shared
{
    public class Person : Object
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
    }
}
