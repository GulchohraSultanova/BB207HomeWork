using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson7
{
    public  class Book:Product
    {
        public string Genre;

        public Book(double price,double count,string name,string no,string genre):base(price, count, name, no)
        {
            Genre= genre;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Name: {Name}, No: {No}, Price: {Price}, Count: {Count}, Genre: {Genre}");
        }
    }
}
