using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson8
{
    
    internal class task1
    {
        //static void Main(string[] args)
        //{
        //    string s = "salam,   Dunya";
        //    OneSpace(s);
        //}




        //Verilmiş string variable-ın dəyərini içərisində hər söz arasında
        //bir boşluq gələcək vəzyətə salan metod.Misalçün bu metoda dəyəri
        //" salam,     Dunya" olan string variable göndərsək həmin metod bu
        //variable-ın dəyərini dəyişib "salam, Dunya" vəziyyətinə salmalıdır.
        public static void OneSpace(string s)
        {
            bool flag = false;
            string newStr = "";
            foreach (char elem in s) {
                if(elem ==' ')
                {
                    if (flag == false)
                    {
                        newStr += elem;
                        flag=true;
                    }

                }
                else
                {
                    newStr += elem;
                   
                }
            }
            Console.WriteLine(newStr);
        }
    }
}
