using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson11
{
    internal class Car : Vehicle
    {
        public string Brand;
        public string Model;
        public int MaxSpeed { get; set; }
        public Car(string brand,string model,int maxSpeed,int year):base(year)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Car: {Brand} {Model}, Year: {Year}, Color: {Color}," +
                $" Max Speed: {MaxSpeed} km/h");

        }
    }
}
