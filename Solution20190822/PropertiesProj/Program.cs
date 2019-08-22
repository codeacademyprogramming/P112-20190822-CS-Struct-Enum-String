using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProj
{
    class Program
    {
        static void Main(string[] args)
        {
            // Car c1 = new Car();
            //c1.SetManufacturer("bmW");
            //Console.WriteLine(c1.GetManufacturer());

            Group group1 = new Group();
            group1.Name = "P112";
            group1.Room = "Titan";

            Mentor mentor1 = new Mentor();

            mentor1.Firstname = "Afiq";
            mentor1.Lastname = "Mehdizade";
            mentor1.Email = "afiq@code.edu.az";
            mentor1.Phone = "0515090515";

            Console.WriteLine(mentor1.GetInfo()); 

            group1.GroupMentor = mentor1;

            Console.ReadLine();
        }
    }
}
