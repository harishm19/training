using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_06_03
{
    class PersonAdded
    {
        public static void Main()
        {

            List<Person> ListOne = new List<Person>();

            ListOne.Add(new Person { Id = 1, Name = "Litesh", BirthPlace = "Bengaluru" });
            ListOne.Add(new Person { Id = 2, Name = "Srinivas", BirthPlace = "Guntoor" });
            ListOne.Add(new Person { Id = 3, Name = "Pavan", BirthPlace = "Bengaluru" });
            ListOne.Add(new Person { Id = 4, Name = "Suman", BirthPlace = "Bengaluru" });
            ListOne.Add(new Person { Id = 5, Name = "Lakshmi", BirthPlace = "Bengaluru" });
            ListOne.Add(new Person { Id = 6, Name = "Muthu", BirthPlace = "TAmil Nadu" });


            List<Person> ListTwo = new List<Person>();

            ListTwo.Add(new Person { Id = 1, Name = "Vani", BirthPlace = "Tirupathi" });
            ListTwo.Add(new Person { Id = 2, Name = "Kavya", BirthPlace = "Bengaluru" });
            ListTwo.Add(new Person { Id = 3, Name = "Harish", BirthPlace = "tumkur" });
            ListTwo.Add(new Person { Id = 4, Name = "Sameem", BirthPlace = "Bengaluru" });
            ListTwo.Add(new Person { Id = 5, Name = "Manoj", BirthPlace = "Bengaluru" });
            ListTwo.Add(new Person { Id = 6, Name = "Himanshu", BirthPlace = "Bengaluru" });


            foreach (var ele in ListOne)
            {
                Console.WriteLine("Name : " + ele.Name +" BirthPlace : "+ ele.BirthPlace);
            }


            Console.WriteLine();
            Console.WriteLine();

            foreach (var ele in ListTwo)
            {
                Console.WriteLine("Name : " + ele.Name + " BirthPlace : " + ele.BirthPlace);
            }

            List<Person> ResultList = new List<Person>();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Showing all who all are from Bangalore");
            Console.WriteLine();


            for (int i = 0; i < ListOne.Count; i++)
            {
                for (int j = 0; j < ListTwo.Count; j++)
                {
                    if (ListOne[i].BirthPlace == ListTwo[j].BirthPlace)
                    {
                        ResultList.Add(ListTwo[j]);
                    }
                }
            }

            for (int i = 0; i < ListOne.Count; i++)
            {
                for (int j = 0; j < ListTwo.Count; j++)
                {
                    if (ListOne[i].BirthPlace == ListTwo[j].BirthPlace)
                    {
                        ResultList.Add(ListOne[j]);
                    }
                }
            }
            //for (int i = 0; i < ListOne.Count; i++)
            //{
            //    for (int j = 0; j < ListTwo.Count; j++)
            //    {
            //        if (ListOne[i].BirthPlace == ListTwo[j].BirthPlace)
            //        {
            //            ResultList.Add(ListOne[j]);
            //        }
            //    }
            //}

            //for (int i=0,j=0;i<ListOne.Count;i++)
            //{
            //        if (ListOne[i].BirthPlace == ListTwo[i].BirthPlace)
            //        {
            //            ResultList.Add(ListOne[i]);
            //            ResultList.Add(ListTwo[i]);
            //        }

            //}

            foreach (var ele in ResultList)
            {
                Console.WriteLine("Name : " + ele.Name + " BirthPlace : " + ele.BirthPlace);
            }
        }
    }

    class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string BirthPlace { get; set; }
    }

}
