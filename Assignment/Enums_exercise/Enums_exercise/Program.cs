using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_exercise
{
    class customer
    {

    }
    class Program
    {

        /*enum weekdays { mon,tue,wed,thr,fri=8,sat=9,sun};*///syntax
        //if i put explicitly tue=1
        static void Main(string[] args)
        {
            var array = new int[] { 4, 3, 5, 6, 5, 3, 2, 8, 90, 45 };
            var result = new List<int>();
            foreach (var item in array)
            {
                bool found = false;
                foreach (var resultitem in result)
                {
                    if (resultitem == item)

                        found = true;
                }
                if (!found)
                {
                    result.Add(item);
                }

            }
            int evensum = 0;
            foreach (var item in result)
            {
                if (item % 2 == 0)
                {
                    evensum = evensum + item;
                }
            }
            Console.WriteLine("display fresh array");
            foreach (var item in result)
            {
                Console.Write("{0,3}", item);
            }
            Console.WriteLine("\n sum of even nuberss {0}", evensum);
            Console.ReadLine();
        }

    }
}

