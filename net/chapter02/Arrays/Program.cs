using System;

namespace Arrays{
    class Program{
        static void Main(string[] args){
            
            string[] names; // can reference any array of strings

            // allocating memory for four strings in an array
            names = new string[4];

            // storing items at index positions
            names[0] = "Reba";
            names[1] = "Keko";
            names[2] = "Mochie";
            names[3] = "Malia";

            // looping through the names
            for(int i=0; i<names.Length; i++){
                // output the item at index position i
                Console.WriteLine(names[i]);
            }
            
        }
    }
}
