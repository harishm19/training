using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_funtions
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "hello suman";
            string strbuilder = x.Substring(0, 5);
            Console.WriteLine(x);
            Console.WriteLine(strbuilder);
            string x2 = "hello";
            x2 += "going where";
            Console.WriteLine(x2);

            string[] weekdays = new string[] { "mon", "tue", "wed", "thr", "fri", "sat", "sun" };

            //substuit for week days and use for weekend

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < weekdays.Length; i++)
            {
                sb.Append(weekdays[i]);
                if(i<weekdays.Length-2)
                {
                    sb.Append(',');
                }
                else if(i==weekdays.Length-2)
                {
                    sb.Append("add");
                }
            }
            Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
