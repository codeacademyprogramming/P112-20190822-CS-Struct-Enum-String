using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructProject
{
    public struct User
    {
        public string firstname;
        public string lastname;
        public int age;

        public int MyProperty { get; set; }

        public User(string fname, string lname, int age, int mprop)
        {
            firstname = fname;
            lastname = lname;
            this.age = age;
            MyProperty = mprop;
        }


    }

}
