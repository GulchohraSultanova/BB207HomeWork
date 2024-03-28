using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson8
{
    internal class task4
    {
        //static void Main(string[] args)
        //{
        //    string s = "Hello World Ana";
        //    Console.WriteLine(CapitalLetter(s));
        //}



        //Verilmiş string dəyərin içərisində 2 söz olmasını
        //və hər bir sözün böyük hərflə başlamasını yoxlayan metod
        public static bool CapitalLetter(string s)
        {
            bool flag = true;
            int count = 0;
            if ((s[0]>='A' && s[0]<='Z') || (s[0]>='a' && s[0] <= 'z'))
            {
                if(!(s[0] >= 'A' && s[0] <= 'Z'))
                {
                    flag = false;
                }
            }
            for (int i = 0; i < s.Length-1; i++)
            {
                if (s[i]==' ' && ((s[i+1] >= 'A' && s[i+1] <= 'Z') || (s[i+1] >= 'a' && s[i+1] <= 'z'))){
                    count++;
                    if(!(s[i+1] >= 'A' && s[i+1] <= 'Z'))
                    {
                        flag = false;
                    }
                }
            }
            if(count<1)
            {
                flag = false;
            }
          
            return flag;

        }
    }
}
