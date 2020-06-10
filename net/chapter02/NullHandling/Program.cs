#nullable enable
using System;

namespace NullHandling{

    class Address{
        public string? Building;
        public string Street = string.Empty;
        public string City = string.Empty;
        public string Region = string.Empty;
    }

    class Program{
        static void Main(string[] args){
            
            int thisCannotBeNull = 4;
            // thisCannotBeNull = null; // compiler error

            int? thisCouldBeNull = null;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            thisCouldBeNull = 7;
            Console.WriteLine(thisCouldBeNull);
            Console.WriteLine(thisCouldBeNull.GetValueOrDefault());

            var address = new Address();
            address.Building = null;
            address.Street = null;
            address.City = "Matamoros";
            address.Region = null;

            // check that the variable is not null before using it
            if(thisCouldBeNull != null){
                // access a member of thisCouldBeNull
                int length = thisCouldBeNull.Length; // could throw an exception
            }

            /*
                If you're trying to use a member of a variable that might be _null_,
                use the null conditional operator `?.`as shown in the following code 
            */

            string authorName = null;

            // the following throws a NullReferenceException
            int x = authorName.Length;

            // instead of throwing an exception, null is assigned to y
            int? y = authorName?.Length;

            // result will be 3 if authoName?.Length is null
            var result = authorName?.Length ?? 3;
            Console.WriteLine(result);

        }
    }
}
