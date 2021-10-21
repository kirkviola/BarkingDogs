using System;
using System.Collections.Generic;

namespace BarkingDogs
{
    class Program
    {
        static void Main(string[] args)
        {
            var Dogs = new List<IBark>()
            {
                new Collie(),
                new Boxer(),
                new Chihuahua()
            };
            foreach(var dog in Dogs)
            {
                Console.WriteLine($"The dog {dog.Name} barks {dog.Bark()}");
                var chawawa = dog as Chihuahua;
                // creates a variable that allows Interface element in the list behave like the class
                // that is linked to the interface.
                if(chawawa != null)
                {
                    Console.WriteLine(chawawa.Walk()); 
                }
                var coll = dog as Collie;
                if(coll != null)
                {
                    Console.WriteLine(coll.Color);
                }
            }
        }
    }
}
