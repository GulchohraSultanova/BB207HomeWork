using BB207HomeWork._lesson10;
using BB207HomeWork.lesson6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson10
{
    internal class Galery
    {
        public int Id;
        public string Name;
        public Car[] Cars = new Car[0];
        public void AddCar(Car car)
        {
            Array.Resize(ref Cars, Cars.Length + 1);
            Cars[Cars.Length - 1] = car;
            Console.WriteLine($"{car.Name} added in galery!");
        }
        public void ShowAllCars()
        {
            foreach (Car car in Cars)
            {
                car.ShowCarInfo();
            }
        }
        public Car[] GetAllCars() { 
            return Cars;
        }
        public Car FindCarById(int id)
        {

            foreach (Car car in Cars)
            {
                if (car != null && car.Id == id)
                    return car;
            }
            return null;
        }
        public Car FindCarByCarCode(string carCode)
        {
            foreach (Car car in Cars)
            {
                if (car != null && car.CarCode == carCode)
                    return car;
            }
            return null;
        }
        public Car[] FindCarsBySpeedInterval(int minSpeedInterval, int maxSpeedInterval)
        {
            
            Car[] speedCars = new Car[0];
            foreach (Car car in Cars)
            {
                if (car.Speed >= minSpeedInterval && car.Speed <= maxSpeedInterval)
                {
                   
                    Array.Resize(ref speedCars, speedCars.Length + 1);
                    speedCars[speedCars.Length - 1] = car;
                }


            }
            
            return speedCars;
        }

    }
}
