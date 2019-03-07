using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Practice_06_03
{
    class Helper
    {
        public static void swap(ref int x, ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static void swap(ref DateTime x, ref DateTime y)
        {
            DateTime temp;
            temp = x;
            x = y;
            y = temp;
        }

        public static void swap(ref string x, ref string y)
        {
            string temp;
            temp = x;
            x = y;
            y = temp;
        }
    }
}
