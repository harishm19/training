using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Practice
{
    // 
    class ExampleForOperatorOverloading
    {
        int a;


        public ExampleForOperatorOverloading(int a)
        {
            this.a = a;
        }


        public ExampleForOperatorOverloading()
        {

        }


        public static void main()
        {
            ExampleForOperatorOverloading exampleForOperatorOverloading0 = new ExampleForOperatorOverloading();
            ExampleForOperatorOverloading exampleForOperatorOverloading = new ExampleForOperatorOverloading();
            ExampleForOperatorOverloading exampleForOperatorOverloading1 = new ExampleForOperatorOverloading(20);
            ExampleForOperatorOverloading exampleForOperatorOverloading2 = new ExampleForOperatorOverloading(30);

            ExampleForOperatorOverloading exampleForOperatorOverloading10 = new ExampleForOperatorOverloading(2);
            ExampleForOperatorOverloading exampleForOperatorOverloading20 = new ExampleForOperatorOverloading(3);

            exampleForOperatorOverloading0.a = exampleForOperatorOverloading10.a + exampleForOperatorOverloading20.a;


            exampleForOperatorOverloading = exampleForOperatorOverloading1 + exampleForOperatorOverloading2;


            Console.WriteLine("with operator overloading {0}", exampleForOperatorOverloading.a);

            Console.WriteLine("with operator overloading {0} and without using it {1}", exampleForOperatorOverloading.a, exampleForOperatorOverloading0.a);
            
        }

        public static ExampleForOperatorOverloading operator +(ExampleForOperatorOverloading exampleForOperatorOverloading1, ExampleForOperatorOverloading exampleForOperatorOverloading2)
        {
            ExampleForOperatorOverloading exampleForOperatorOverloading = new ExampleForOperatorOverloading();
            exampleForOperatorOverloading.a = exampleForOperatorOverloading1.a + exampleForOperatorOverloading2.a;

            return exampleForOperatorOverloading;
        }

    }
}
