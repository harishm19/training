using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleForInternal;


namespace AccessModifier_05_03
{
    class Program
    {
    }

    class One : Class1
    {
        private int a = 0;

        public int b = 1;

        protected int c = 2;

        internal int d = 3;

        protected internal int e = 4;

        internal int f { get; set; }

        public static void ForUse()
        {
            One one = new One();

            one.MyPropertyForProtectedInternal = 100;
        }
    }

    class Two : One
    {
        public static void Main()
        {

            One one = new One();
            // here Variable f is internal in its base class 
            // so it will be accessable only by creating obj of its class 
            one.f = 100;

            
            Two two = new Two();
            // here c is protected in its base class which cannot 
            //be accessed by creating obj of tat class so we have to inherit and access it by creating child class obj
            two.c = 100;

            // here MyPropertyForProtectedInternal is of different assembly so we have to add reference and then inherit
            two.MyPropertyForProtectedInternal = 100;
        }
    }
}
