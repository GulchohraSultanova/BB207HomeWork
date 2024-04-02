using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson11
{
   abstract class Vehicle
    {
        public string Color;
        public int Year;
        public Vehicle(int year)
        {
            
            Year=year;
        }
        public abstract void ShowInfo();
    }
}
