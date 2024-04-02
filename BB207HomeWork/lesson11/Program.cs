using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle[] vehicles = new Vehicle[4];
            vehicles[0] = new Car("BMW", "M5", 200, 2000)
            {
                Color = "Black"
            };
            vehicles[1] = new Car("Toyota", "Camry", 180, 2020)
            {
                Color = "Red"
            };
            vehicles[2] = new Bus(30, 2010)
            {
                Color = "Blue"
            };
            vehicles[3] = new Bus(20, 2000)
            {
                Color = "Silver"
            };
            foreach (var vehicle in vehicles)
            {
                vehicle.ShowInfo();
            }

        }

    }
}
