using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Practice_06_03
{
    class ExampleForArray
    {

        public static void Main123()
        {
            int i, j, sum;

            int[] a = new int[] { 1, 2, 3, 4 };


            Console.WriteLine("enter the no of elements in array u wanna enter");

            int NoOfElements = int.Parse(Console.ReadLine());

            int[] array = new int[NoOfElements];

            Console.WriteLine("enter {0} elements", NoOfElements);

            for(int index =0; index< NoOfElements; index++)
            {
                array[index] = int.Parse(Console.ReadLine());
            }

            ExampleForArray exampleForArray = new ExampleForArray();

            int[] Result = new int[NoOfElements];

            Result = exampleForArray.AscendingOrderOfArray(array);

            Console.WriteLine("Array in ascending order : ");

            for(int index=0; index<Result.Length; index++)
            {
                Console.WriteLine(Result[index]);
            }

            Console.WriteLine("using for each.....");

            foreach(var ele in Result)
            {
                Console.WriteLine(ele);
            }
        }



        public int[] AscendingOrderOfArray(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                for(int j=i+1; j<array.Length;j++)
                {
                    if(array[i]>array[j])
                    {
                        int temp;
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

    }


    class ExampleForList
    {
        public int Age { get; set; }
        public string Name { get; set; }

    }

    class TestList
    {
        public static void Main()
        {
            List<ExampleForList> list = new List<ExampleForList>();

            list.Add(new ExampleForList { Age = 23, Name="Litesh"});

            list.Add(new ExampleForList { Age = 21, Name = "Pavan" });

            list.Add(new ExampleForList { Age = 22, Name = "Suman" });


            foreach(var ele in list)
            {
                Console.WriteLine("Name : " + ele.Name + "      Age : "+ele.Age);
            }


            Console.WriteLine("Pick someones age  ..........");

            int age = int.Parse(Console.ReadLine());

            foreach (var ele in list)
            {
                if (ele.Age == age)
                    Console.WriteLine("valid");
            }

        }
    }
}
