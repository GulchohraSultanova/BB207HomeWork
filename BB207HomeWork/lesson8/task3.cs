using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson8
{
    internal class task3
    {

        //static void Main(string[] args)
        //{
        //    Console.WriteLine(FirstwordInString("   hello    world"));
        //}


        //Verilmiş string deyerinin icərisindəki ilk sözü tapıq qaytaran metod
        public static string FirstwordInString(string input)
        {
            bool flag= false;
            string firstword = "";
            foreach (char c in input)
            {
                if(c==' ' && flag == false)
                {
                    continue;
                }
                if(c!=' '&& flag == false)
                {
                    flag = true;
                }
                if(flag == true && c == ' ') {
                    break;
                }
                if (flag == true)
                {
                    firstword += c;
                }
            }
            return firstword;
        }

    }
}
