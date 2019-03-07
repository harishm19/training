using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noof_words_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string kk = "hello this venkat raja sathya sai kumara calling from banglore";
            char[] seprator = new char[] { ' ' };
            string[] result = kk.Split(seprator);
            int noofwords = 0;
            foreach (string s in result)
            {
                Console.WriteLine("{0}", s);
                Console.WriteLine("{0}", s.Length);
                noofwords++;
            }
            Console.WriteLine("the no of words in the sentance is{0}", noofwords);

            string kk2 = "hi every 1.this is good place";
            string[] result2 = kk2.Split('.',' ');
            int noofsentences = 0;
            foreach (string s2 in result2)
            {
                Console.WriteLine("{0}", s2);
                noofsentences++;
            }
            Console.WriteLine("the no of sentences is{0}", noofsentences);
            

            Console.ReadLine();
        }
    }
}
