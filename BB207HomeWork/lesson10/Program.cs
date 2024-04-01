using BB207HomeWork._lesson10;
using BB207HomeWork.lesson6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson10
{
     class Program
    {


        static void Main(string[] args)
        {
            Galery galery= new Galery();
            //Masinlarin elave edilmesi
            Car car1 = new Car("BMW", 240);
            Car car2 = new Car("Toyota", 220);
            Car car3 = new Car("Mersedes", 180);
            Car car4 = new Car("Audio", 200);
            Car car5 = new Car("Ford", 200);
            galery.AddCar(car1);
            galery.AddCar(car2);
            galery.AddCar(car3);
            galery.AddCar(car4);
            galery.AddCar(car5);
            Console.WriteLine("--------------------------------------------------------------------------");
            //Bütün avtomobillər göstərilir.
            Console.WriteLine("All Cars:");
            galery.ShowAllCars();
            Console.WriteLine();
            //// ID-ə görə avtomobil göstərilir.
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Find Car by ID:");
            Car carById = galery.FindCarById(1002);
            if (carById != null)
                carById.ShowCarInfo();
            else
                Console.WriteLine("Car not found");
            Console.WriteLine("-----------------------------------------------------------------------------");

            // CarCode-a görə avtomobil göstərilir.
            Console.WriteLine("Find Car by CarCode:");
            Car carByCode = galery.FindCarByCarCode("BM1001");
            if (carByCode != null)
               carByCode.ShowCarInfo();
            else
                Console.WriteLine("Car not found");
            // Suret aralığına görə avtomobillər tapılır və göstərilir
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine("Find Cars by Speed Interval:");
            Car[] carsSpeedInInterval = galery.FindCarsBySpeedInterval(190, 220);
            if (carsSpeedInInterval.Length > 0)
            {
                foreach (var car in carsSpeedInInterval)
                {
                    if (car != null)
                       car.ShowCarInfo();
                }
            }
            else
            {
                Console.WriteLine("No cars found in the search speed interval");
            }


        }

    }
}
