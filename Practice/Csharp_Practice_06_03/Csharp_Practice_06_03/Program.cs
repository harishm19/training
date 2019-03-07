using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Practice_06_03
{
    class Employee
    {

        //params can replace the use of overloading 
        public void tsal(params int[] sal)
        {
            int ts = 0; 

            for(int index =0; index<sal.Length; index++)
            {
                ts = ts + sal[index];
            }

            Console.WriteLine("the sal is : "+ ts);

        }
    }


    class Program
    {
        //call by reference 
        public static void swapForCallByReference(ref int a, ref int b)
        {
            Console.WriteLine("-------swapForCallByReference----------");
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Values after being swapped A : {0} , B : {1}",a,b);
        }


        public static void swapForCallByValue( int a,  int b)
        {
            Console.WriteLine("-------swapForCallByValue----------");
            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Values after being swapped A : {0} , B : {1}", a, b);
        }


        public static void swapUsingOutParam(out int a, out int b)
        {
            Console.WriteLine("-------Using Out Parameter----------");

            a = 10;
            b = 20;

            Console.WriteLine("Values before being swapped A : {0} , B : {1}", a, b);

            int temp;
            temp = a;
            a = b;
            b = temp;
            Console.WriteLine("Values after being swapped A : {0} , B : {1}", a, b);
        }

        static void main()
        {

            int X, Y;

            Console.WriteLine("Enter some values for A and B");

            int A = int.Parse(Console.ReadLine());
            int B = int.Parse(Console.ReadLine());

            Console.WriteLine("Values before being swapped A : {0} , B : {1}", A, B);

            //call by value will not affect the actual value
            swapForCallByValue(A, B);
            Console.WriteLine();
            Console.WriteLine("After swapping Outside the swap method A : {0} , B : {1}", A, B);

            //call by reference will affect the actual value
            swapForCallByReference(ref A, ref B);

            Console.WriteLine();
            Console.WriteLine("After swapping Outside the swap method A : {0} , B : {1}", A, B);


            // when we use out param we dont intialize values for them
            swapUsingOutParam(out X, out Y);



            Employee employee = new Employee();

            int sal = 3000;
            int bonus = 500;

            //by using params we can pass any nos of arguments 
            //if it is an array then each time i have to create an obj and then pass it as an argmunet
            //params reduces the work 
             
            employee.tsal(100, 23,5);
            employee.tsal(sal,bonus);
            employee.tsal('a','d');
        }


        public static void Main123()
        {
            int value1 = 10, value2 = 20;

            Helper.swap(ref value1, ref value2);

            DateTime currentDateTime = DateTime.Now;

            DateTime threeDaysLaterDateTime = DateTime.Now.AddDays(3);

            Helper.swap(ref currentDateTime, ref threeDaysLaterDateTime);

            string MyName = "Litesh", PavanName = "Pavan";

            Helper.swap(ref MyName, ref PavanName);
            
        }
    }
}
