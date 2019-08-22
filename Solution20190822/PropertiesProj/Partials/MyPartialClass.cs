using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PropertiesProj;

namespace PropertiesProj.Partials
{
    public partial class Mentor
    {

        public string GetInfo()
        {
            return Firstname + " " + Lastname;
        }
    }
}
