using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Practice
{
    class DelegateAndEvents
    {

        public DelegateAndEvents()
        {
            myevent = new mydelegate(testfunction);
        }


        public void testfunction()
        {
            Console.WriteLine("test function called.....");
        }


        public delegate void mydelegate();

        public event mydelegate myevent;

        public void add(int x, int y)
        {
            Console.WriteLine("hey {0}", x+y);
        }

        public void sub(int x, int y)
        {
            Console.WriteLine("hey sub here {0}",x-y);
        }

        //this delegate will act as an pointer to all methods with same signature 
        public delegate void myDelegate(int x, int y);


        public delegate void myDelegateForLamada(int x, int y);

        public delegate int myDelegateForLamadaUsingReturnValue(int x, int y);

        public static void main()
        {
            DelegateAndEvents delegateAndEvent = new DelegateAndEvents();

            //mydelegate is now pointing to add method, no other operation will be performed rite now  
            myDelegate mydelegate = new myDelegate(delegateAndEvent.add);

            mydelegate(1, 3);
            //the same delegate is now pointing to another method, sub
            mydelegate += new myDelegate(delegateAndEvent.sub);
            
            //here am passing values to those methods which mydelegate is pointing to, and eventually those methods will be called.
            mydelegate(12,34);


            //using lamada

            myDelegateForLamada mydelegateForLamada = (x, y) => { Console.WriteLine("adding x and y using Lamada {0} : ",x+y ); };

            mydelegateForLamada(12, 4);

            //using lamada for returning value

            myDelegateForLamadaUsingReturnValue mydelegateForLamadaUsingReturnValue = (x, y) => { return (x + y); };

            mydelegateForLamadaUsingReturnValue(3,6);




            delegateAndEvent.myevent();


        }

    }
}
