using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productlist_display_delet_using_collectioins
{
    class product
    {
        public int productid { get; set; }
        public string productname { get; set; }
        public static List<product> retriveproduct()
        {
            List<product> plist = new List<product>()
            {
                new product {productid=101,productname="tv" },
                new product {productid=102,productname="laptop" },
                new product {productid=103,productname="tablet" },
                new product {productid=104,productname="Pendrive" }

            };
            return plist;
        }
        public static void deletproduct(List<product> plist1,string prodname1)
        {
            for (int i = 0; i < plist1.Count; i++)
            {
                if (plist1[i].productname.Equals(prodname1))
                    plist1.RemoveAt(i);
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<product> plist1 = product.retriveproduct();
            Console.WriteLine("The products:");
            Console.WriteLine("---------- --------:");
            foreach (product prd in plist1)
            {
                Console.WriteLine("productid;{0} and productname:{1}", prd.productid, prd.productname);
            }
            Console.WriteLine("ënter the product name that to delet");
            string prodname = Console.ReadLine();
            product.deletproduct(plist1, prodname);
            foreach (product prd in plist1)
            {
                Console.WriteLine("product id:{0} and  productnamae;{1}", prd.productid, prd.productname);
            }
            Console.ReadLine();
        }
    }
}
