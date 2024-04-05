using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson12
{
    internal class Product
    {
        private static int _no;
        public int No { get; set; }
        public string Name { get; set; }
        private int _price;
        public string Type;
        public int Count;

        public int Price
        {
            get { return _price; }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    Console.WriteLine("Price is not correct!");
                }
            }
        }
        public Product(string name, int price, string type, int count)
        {
            No = ++_no;
            Name = name;
            _price = price;
            Type = type;
            Count = count;

        }
        public override string ToString()
        {
            return $"No: {No} Name: {Name} Price: {Price}  Type: {Type}  Count: {Count}";
        }
    }
}
