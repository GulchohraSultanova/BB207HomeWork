//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BB207HomeWork.lesson5
//{
//    internal class Problem4
//    {
//        static void Main(string[] args)
//        {
//            int n = int.Parse(Console.ReadLine());
//            int[] fibonacci = FibonacciSeries(n);
//            for (int i = 0; i < fibonacci.Length; i++)
//            {
//                Console.Write(fibonacci[i]+" ");
//            }
//        }
//        public static int[] FibonacciSeries(int n)
//        {
//            if(n <= 0) { 
            
//                return new int[0];
//            }
//            int[] series = new int[n];
//            series[0] = 0;
//            series[1] = 1;
//            if(n==1 || n==2)
//            {
//                return series;
//            }
//            else
//            {
//                for(int i = 2; i < n; i++) {
//                    series[i] = series[i - 1] + series[i-2];
//                }
//            }
//            return series;
//        }
        
//    }
//}
