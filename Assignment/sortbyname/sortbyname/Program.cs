using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortbyname
{
    class Program
    {
        class customer:IComparable
        {
            public int custid { get; set; }
            public string custname { get; set; }

            public int CompareTo(object obj)
            {
                customer otherobj = (customer)obj;
                return this.custname.CompareTo(otherobj.custname);
            }
        }
        static void Main(string[] args)
        {
            int[] a = new int[] { 12, 34, 24, 45, 90, 30 };
            Array.Sort(a);
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write("{0,3}", a[i]);
            }
            customer[] cc = new customer[4];
            cc[0] = new customer { custid = 101, custname = "kavya" };
            cc[1] = new customer { custid = 102, custname = "raja" };
            cc[2] = new customer { custid = 103, custname = "govinda" };
            cc[3] = new customer { custid = 104, custname = "ragu" };
            Array.Sort(cc);
            for (int i = 0; i < cc.Length; i++)
            {
                Console.WriteLine("\n\n\n{0} and name is {1}", cc[i].custname, cc[i].custid);
            }
            Console.ReadLine();
        }
    }
}

