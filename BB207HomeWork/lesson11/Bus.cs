using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson11
{
    internal class Bus : Vehicle
    {
        public int PassengerCount { get; set; }
        public Bus(int passengerCount, int year) :base(year)
        {
            PassengerCount = passengerCount;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Bus, Year: {Year}, Color: {Color}, Passenger Count: {PassengerCount}");
        }
    }
}
