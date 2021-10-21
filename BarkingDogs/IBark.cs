using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarkingDogs
{
    interface IBark
    {
        string Name { get; set; }
        string Bark();
    }
}
