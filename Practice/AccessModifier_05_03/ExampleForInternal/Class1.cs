using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleForInternal
{
    public class Class1
    {

        // Variable MyPropertyForProtectedInternal will be accessable by other classes of different assembly 
        protected internal int MyPropertyForProtectedInternal { get; set; }
    }
}
