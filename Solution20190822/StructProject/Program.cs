using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //User u = new User();

            //u.firstname = "Gunel";
            //u.lastname = "Huseynova";
            //u.age = 15;

            //Console.WriteLine(u.firstname + " " +u.lastname);


            //Student s1 = new Student();
            //s1.firstname = "Huseyn";

            //Student s2 = s1;
            //Student s3 = s2;

            //Console.WriteLine(s1.firstname);
            //Console.WriteLine(s2.firstname);
            //Console.WriteLine(s3.firstname);
            //s1.firstname = "Yaver";
            //Console.WriteLine(s1.firstname);
            //Console.WriteLine(s2.firstname);
            //Console.WriteLine(s3.firstname);
            //Console.WriteLine("====================");


            //User u1 = new User();
            //u1.firstname = "Teymur";

            //User u2 = u1;
            //User u3 = u2;

            //Console.WriteLine(u1.firstname);
            //Console.WriteLine(u2.firstname);
            //Console.WriteLine(u3.firstname);

            //u1.firstname = "Anar";

            //Console.WriteLine(u1.firstname);
            //Console.WriteLine(u2.firstname);
            //Console.WriteLine(u3.firstname);


            //Console.WriteLine((int)Weekday.Shenbe);

            int res = 404;

            if (res == (int)HttpResponses.NotFound)
            {
                Console.WriteLine("Error - NOR FOUND");
            }


            Console.ReadLine();
        }
    }



}
