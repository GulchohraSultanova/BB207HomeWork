using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson12
{
    internal class Person
    {
        private static int _id;
        public int Id { get; set; }
        public string FullName { get; set; }
        private sbyte _age;

        public sbyte Age
        {
            get { return _age; }
            set
            {
                if (value > 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    Console.WriteLine("Age is not correct!");
                }
            }
        }

        public double Cash { get; set; }
        public Person(string fullName, sbyte age)
        {
            Id = ++_id;
            FullName = fullName;
            Age = age;
        }
        public override string ToString()
        {
            return $"Id: {Id} FullName: {FullName} Age: {Age} ";
        }
    }
}
