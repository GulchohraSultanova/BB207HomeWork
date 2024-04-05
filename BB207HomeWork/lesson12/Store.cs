using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson12
{
    internal class Store
    {
        private static int _id;
        public int Id { get; set; }
        public Product[] Products = { };



        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length+1);
            Products[Products.Length-1] = product;
        }
        public void RemoveProductByNo(int no)
        {
            Product[] arr = { };
            foreach (Product p in Products)
            {
                if (p.No != no) { 
                    Array.Resize(ref arr, arr.Length+1);
                    arr[arr.Length - 1] = p;
                }
            }
            Products= arr;
            Console.WriteLine("Product to remove in store!");
        }
        public Product GetProduct(int no)
        {
            foreach (Product p in Products) { 
                if ( p.No == no)
                {
                    return p;
                }
            }
            return null;
        }
        public Product [] FilterProductsByType(string type)
        {
            Product[] arr = { };
            foreach (Product p in Products)
            {
                if (p.Type == type)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = p;
                }
            }
            return arr;
        }
        public Product[] FilterProductsByName(string name)
        {
            Product[] arr = { };
            foreach (Product p in Products)
            {
                if (p.Name == name)
                {
                    Array.Resize(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = p;
                }
            }
            return arr;
        }
        public void Sale(int no, Person person)
        {
            foreach (Product p in Products)
            {
                if (p.No == no)
                {
                    p.Count -= 1;
                    person.Cash -= p.Price;
                }
            }
            Console.WriteLine("Product bought!");
        }


    }
}
