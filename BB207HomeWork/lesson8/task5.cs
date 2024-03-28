using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BB207HomeWork.lesson8
{
    internal class task5
    {

        //static void Main(string[] args)
        //{
        //    int[] array = { 1, 2, 3, 4, 5, 6, 7 };
        //    int n = 8;
        //   AddNumArray(ref array, n);
        //    foreach (int i in array)
        //    {
        //        Console.Write(i+" ");
        //    }
        //}


        // Parameter olaraq integer array variable-ı (reference) və bir integer value qəbul
        // edən və həmin integer value-nu integer array-ə yəni element kimi əlavə edən metod.
        public static void AddNumArray(ref int[] arr, int a)
        {
            int[] newArray = new int[arr.Length + 1];
            for (int i = 0; i < arr.Length; i++)
            {
                newArray[i] = arr[i];
            }
            newArray[newArray.Length - 1] = a;
           arr= newArray;
        }
    }
}
