using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Practice
{
    class ExampleForOverloading
    {
        int a = 0 , b = 0 , c = 0 ;
        public void add()
        {
            c = a + b;
        }
        public void add(int a, int b)
        {
            c = a + b;
        }

        public void add(double a, int b)
        {
            double c = a + b;
        }
    }

    class TestOverLoding
    {
        public static void main()
        {
            int a = 0, b = 0;

            double c = 0;
            ExampleForOverloading exampleForOverloading = new ExampleForOverloading();

            exampleForOverloading.add();

            exampleForOverloading.add(a, b);

            exampleForOverloading.add(c,a);
        }
    }
}
