using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson13.Serializer.JSONSerializer
{
    internal class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname {  get; set; }
        public byte Age { get; set; }
        public string Address { get; set; }
        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}; Surname: {Surname}; Age: {Age}; Adress: {Address}";
        }


    }
}
