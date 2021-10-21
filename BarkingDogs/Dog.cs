using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    class Dog : IBark
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public string BarkSound { get; set; }

        public string Bark()
        {
            return BarkSound;
        }
        public string Walk()
        {
            return "Walking the dog";
        }
    }
}
