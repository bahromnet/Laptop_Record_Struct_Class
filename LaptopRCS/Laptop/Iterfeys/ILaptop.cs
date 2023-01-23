using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopRCS.Laptop.Iterfeys
{
    internal interface ILaptop
    {
        string on();
        string off();
        string restart();
    }
}
