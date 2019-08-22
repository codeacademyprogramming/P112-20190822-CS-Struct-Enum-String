using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {

        // Name, Surname, Email, Phone, BirthDate
        static void Main(string[] args)
        {
            string yoxlama = "";

            while (yoxlama  != "exit")
            {
                User tezeMushteri = new User();

                Console.Write("Adinizi daxil edin: ");
                tezeMushteri.Name = Console.ReadLine();

                Console.Write("Soyadinizi daxil edin: ");
                tezeMushteri.Surname = Console.ReadLine();

                Console.WriteLine(tezeMushteri.GetInfo());

                Console.WriteLine("Sonlandirmaq ucun exit yazin");
                yoxlama = Console.ReadLine();
                Console.WriteLine("\n=============\n");
            }

        }
    }
}
