using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson8
{
    internal class task2
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine(CorrectString("ana1Aa"));

        //}

        //Göndərilmiş string dəyərin aşğıdaki şərtləri ödəyib ödəmədiyini
        //(bool) qaytaran metod
        //- İçində ən az 1 rəqəm olmalıdır
        // - İçində ən az 1 böyük hərf olmalıdır
        //- İçində ən az 1 kiçik hərf olmalıdır
        public static bool CorrectString(string str)
        {
            bool flag1 = false;
            bool flag2 = false;
            bool flag3 = false;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= '0' && str[i] <= '9')
                {
                    flag1 = true;
                }
                if (str[i] >= 'A' && str[i] <= 'Z')
                {
                    flag2 = true;
                }
                if ((str[i] >= 'a' && str[i] <= 'z'))
                {
                    flag3 = true;
                }
            }
            if(flag1 && flag2 && flag3) {
            return true;
            }
            else
            {
                return false;
            }
        }
    }
}
