using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProj
{
    class Group
    {
        public string Name { get; set; }
        public string Room { get; set; }

        public Mentor GroupMentor { get; set; }
        public Teacher GroupTeacher { get; set; }

        public List<Student> Students { get; set; }
    }
}
