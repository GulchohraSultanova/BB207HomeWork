using BB207HomeWork.lesson10;
using BB207HomeWork.lesson6;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork._lesson10
{
    public class Car
    {
        private static int nextId = 1000;

        public int Id { get; }
        public string Name;
        public int Speed;
        public string CarCode;
        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
          
            Id=++nextId;
            int count = 0;
            for (int i = 0; i < Name.Length; i++)
            {
                if (char.IsUpper(Name[i]))
                {
                    if (count < 2)
                    {
                        CarCode += Name[i];
                        count++;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            CarCode += Id;
        }
       
        public void ShowCarInfo() {
            Console.WriteLine($"Id: {Id}, Name: {Name}, Speed: {Speed}, Car code: {CarCode}");
                }

    }
}
