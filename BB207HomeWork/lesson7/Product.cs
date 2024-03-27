using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson7
{
    public  class Product
    {
        public string Name;
        public string No;
        private double  _price;

        public double  Price
        {
            get { return _price; }
            set { 
                if(value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price is not correct!");
                }
            }
        }
        private double _count;

        public double Count
        {
            get { return _count; }
            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("Count is not correct!");
                }
            }
        }
       
        public Product(double price,double count,string name,string no) {
            Price = price;
            Count = count;
            Name = name;
            No = no; 
        }
    }
}
