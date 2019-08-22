using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesProj
{
    class Car
    {

        string Model;
        string Color;
        string BanCode;
        DateTime Year;

        public string Manufacturer { get; set; }

        //public void SetManufacturer(string manu)
        //{
        //    Manufacturer = manu;
        //}

        //public string GetManufacturer()
        //{
        //    return Manufacturer;
        //}
    }
}
