using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine("--------------WELCOME!---------------");
        MENU:
            Console.WriteLine("MENU:");
            Console.WriteLine("1.Add the product in store!");
            Console.WriteLine("2.Remove the product in store!");
            Console.WriteLine("3.View the product with search no in store!");
            Console.WriteLine("4.View the products with search type in store!");
            Console.WriteLine("5.View the products with search name in store!");
            Console.WriteLine("6.View the products in store!");

            Console.WriteLine("0.Exitin programing...");
            Console.WriteLine();
            Console.WriteLine("Enter the choice: ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Write("Enter the product name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine();
                    int price, count;
                    do
                    {
                        Console.Write("Enter the product price:");

                    } while (!int.TryParse(Console.ReadLine(), out price));
                    Console.WriteLine();
                    Console.Write("Enter the product type: ");
                    string type = Console.ReadLine();
                    Console.WriteLine();
                    do
                    {
                        Console.Write("Enter the product count:");

                    } while (!int.TryParse(Console.ReadLine(), out count));
                    
                    store.AddProduct(new Product(name,price,type,count));
                    Console.WriteLine("Product is added!");
                    goto MENU;
                case "2":
                    int no;
                    do
                    {
                        Console.Write("Enter the remove product no:");

                    } while (!int.TryParse(Console.ReadLine(), out no));
                    store.RemoveProductByNo(no);

                    goto MENU;
                case "3":

                    int no1;
                    do
                    {
                        Console.Write("Enter the  search product no:");

                    } while (!int.TryParse(Console.ReadLine(), out no1));

                    try
                    {
                        Console.WriteLine(store.GetProduct(no1).ToString());
                        goto MENU;
                    }
                    catch (Exception e)
                    {

                        Console.WriteLine("This no product with id!");
                        goto MENU;
                    }
                   
                case "4":
                    Console.Write("Enter the search type:");
                    string searchType = Console.ReadLine();
                    Console.WriteLine();
                    Product[] arr = store.FilterProductsByName(searchType);
                    if (arr.Length==0)
                    {
                        Console.WriteLine("This product no with by type ");
                    }
                    else
                    {
                        Console.WriteLine("Products with search type:");
                        foreach (Product product1 in arr)
                        {
                            Console.WriteLine(product1);
                        }
                    }
                    goto MENU;
                case "5":
                    Console.Write("Enter the search name:");
                    string searchName = Console.ReadLine();
                    Console.WriteLine();
                    Product[] arr1= store.FilterProductsByName(searchName);
                    if (arr1.Length==0)
                    {
                        Console.WriteLine("This product no with by name ");
                    }
                    else
                    {
                        Console.WriteLine("Products with search name:");
                        foreach (Product product1 in arr1)
                        {
                            Console.WriteLine(product1);

                        }
                    }
                    goto MENU;
                case "6":
                    foreach(Product product1 in store.Products)
                    {

                        Console.WriteLine(product1);
                    }
                    goto MENU;
                case "0":
                    break;

                default:
                    Console.WriteLine("Enter the correct choice!");
                    goto MENU;
            }







        }
    }
}
